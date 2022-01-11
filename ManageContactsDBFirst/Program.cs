using ManageContactsDBFirst.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageContactsDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manage Contacts - CRUD
            // DAL - EF
            // Approach - DB First - existing database and tables
            // install ef - using nuget.org PM/PMC

            // Insert new contact
            // write only oo code
            ContactsEDMModel db = new ContactsEDMModel();
            Contact c = new Contact { Name = "Rohit", Email = "rohith@mail.com", Location = "Bangalore", Mobile = "234234234", Dob = new DateTime(2000, 10, 20) };
            db.Contacts.Add(c);
            db.SaveChanges();
            Console.WriteLine("Contact saved....");
        }
    }
}
