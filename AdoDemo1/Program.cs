using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoDemo1.Entities;
using AdoDemo1.DataAccess;

namespace AdoDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // want to manage (CRUD) all my contacts
            // save contact information into db

            // name
            // email
            // mobile
            // location
            // dob


            // One Time
            //done- choose database server - MS SQL Server/Sql Express/Sql Local DB 
            //done- create or choose database
            //done create or choose table

            // perform crud operations

            try
            {
                IContactsRepository repo = new ContactsRepository();
                repo.FundTransfer(111, 222, 1000);
                Console.WriteLine("Successfully funds transfered");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
