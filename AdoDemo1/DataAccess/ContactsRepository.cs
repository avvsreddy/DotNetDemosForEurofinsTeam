using AdoDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
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


            string sqlInsert = "sp_insertcantact";

            // 'ravi';delete contacts'


            // open connection with db
            IDbConnection conn = GetConnection();

            //Console.WriteLine("Connected to sql server local db");

            // send sql cmd to db
            // SqlCommand cmd = new SqlCommand();
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlInsert;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = conn;

            IDbDataParameter p1 = cmd.CreateParameter();
            

            //SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@name";
            p1.Value = contact.Name;
            cmd.Parameters.Add(p1);

            IDbDataParameter p2 = cmd.CreateParameter();
            p2.Value = contact.Mobile;
            p2.ParameterName = "@mobile";
            cmd.Parameters.Add(p2);
            //cmd.Parameters.AddWithValue("@mobile", contact.Mobile);
            //cmd.Parameters.AddWithValue("@loc", contact.Location);
            IDbDataParameter p3 = cmd.CreateParameter();
            p3.ParameterName = "@loc";
            p3.Value = contact.Location;
            cmd.Parameters.Add(p3);
            //cmd.Parameters.AddWithValue("@dob", contact.Dob);
            IDbDataParameter p4 = cmd.CreateParameter();
            p4.ParameterName = "@email";
            p4.Value = contact.Email;
            cmd.Parameters.Add(p4);
            //SqlParameter p2 = new SqlParameter("@email", contact.Email);
            //cmd.Parameters.Add(p2);
            IDbDataParameter p5 = cmd.CreateParameter();
            p5.ParameterName = "@dob";
            p5.Value = contact.Dob;
            cmd.Parameters.Add(p5);
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

        private static IDbConnection GetConnection()
        {
            string provider = ConfigurationManager.ConnectionStrings["contacts"].ProviderName;
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            //SqlConnection conn = new SqlConnection();
            IDbConnection conn = factory.CreateConnection();
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
            //OleDbConnection conn = new OleDbConnection();
            //OleDbCommand cmd = new OleDbCommand();


            string sqlSelect = "select * from contacts where contactid = @cid";
            IDbConnection conn = GetConnection();
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlSelect;
            cmd.Connection = conn;
            //(sqlSelect, conn);

            IDbDataParameter p1 = cmd.CreateParameter();
            p1.ParameterName = "@cid";
            p1.Value = contactId;
            cmd.Parameters.Add(p1);
            //cmd.Parameters.AddWithValue("@cid", contactId);
             Contact c = new Contact();
            IDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                //if (!reader.)
                //    throw new ContactNotFoundException("Contact not available");

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

        public List<Contact> GetContactsBornedToday()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetContactsBornedThisMonth()
        {
            throw new NotImplementedException();
        }

        public bool FundTransfer(int fromAccNo, int toAccNo, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
