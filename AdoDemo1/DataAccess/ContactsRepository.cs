using AdoDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo1.DataAccess
{
    public class ContactsRepository : IContactsRepository
    {
        public bool SaveContact(Contact contact)
        {
            // prepare sql insert statement
            string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Email}','{contact.Mobile}','{contact.Location}','{contact.Dob}')";

            // open connection with db
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2022DB;Integrated Security=True";
            conn.Open();
            Console.WriteLine("Connected to sql server local db");

            // send sql cmd to db
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            int count = cmd.ExecuteNonQuery();
            // close the db connection
            conn.Close();
            return count > 0;
        }
    }
}
