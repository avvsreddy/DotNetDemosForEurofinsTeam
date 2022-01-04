using AdoDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo1.DataAccess
{
    public class ContactsRepository : IContactsRepository
    {
        public bool DeleteContact(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool SaveContact(Contact contact)
        {
            // prepare sql insert statement
            //string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Email}','{contact.Mobile}','{contact.Location}','{contact.Dob}')";


            string sqlInsert = $"insert into contacts values (@name,@email,@mobile,@loc,@dob)";

            // 'ravi';delete contacts'


            // open connection with db
            SqlConnection conn = GetConnection();

            //Console.WriteLine("Connected to sql server local db");

            // send sql cmd to db
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@name";
            p1.Value = contact.Name;
            cmd.Parameters.Add(p1);

            cmd.Parameters.AddWithValue("@mobile", contact.Mobile);
            cmd.Parameters.AddWithValue("@loc", contact.Location);
            cmd.Parameters.AddWithValue("@dob", contact.Dob);

            SqlParameter p2 = new SqlParameter("@email", contact.Email);
            cmd.Parameters.Add(p2);
            int count;
            try
            {
                conn.Open();
                count = cmd.ExecuteNonQuery();
                // close the db connection
            }
            //catch(SqlException ex)
            //{
            //    // convert sql exception into custom exp
            //    // log ex
            //    // rethrow
            //}
            finally
            {
                conn.Close();
            }
            return count > 0;
        }

        private static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["contacts"].ConnectionString;
            return conn;
        }

        public bool UpdateContact(int contactId, Contact modifiedContact)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// searches contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>contact object</returns>
        /// <exception cref="ContactNotFoundException"/>
        public Contact GetContactById(int contactId)
        {
            string sqlSelect = "select * from contacts where contactid = @cid";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("@cid", contactId);
             Contact c = new Contact();
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                    throw new ContactNotFoundException("Contact not available");

                c.ContactID = (int)reader[0];
                c.Name = reader[1].ToString();
                c.Email = reader.GetString(2);
                c.Mobile = reader["Mobile"].ToString();
                c.Location = reader["location"].ToString();
                c.Dob = reader[5].ToString();
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return c;
        }

        public List<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetContactsByLocation(string location)
        {
            throw new NotImplementedException();
        }
    }
}
