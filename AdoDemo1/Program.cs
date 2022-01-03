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

            Contact c = new Contact();
            Console.Write("Enter Contact Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Location: ");
            c.Location = Console.ReadLine();
            Console.Write("Enter DOB: ");
            c.Dob = Console.ReadLine();

            IContactsRepository repo = new ContactsRepository();


            if (repo.SaveContact(c))
                Console.WriteLine("Contact saved....");
        }

        
    }
}
