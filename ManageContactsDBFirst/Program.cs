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

            // get all contacts
            // linq to entities

            //var contacts = from c in db.Contacts
            //               select c;
            //// display all contact names

            //foreach (var item in contacts)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // change sachin's mobile number

            // get sachin's object from dbset

            //var sachin = (from c in db.Contacts
            //             where c.ContactID == 1
            //             select c).FirstOrDefault();
            //sachin.Mobile = "99999999";
            //db.SaveChanges();

            // get ramesh's object

            var ramesh = db.Contacts.Find(5);
            db.Contacts.Remove(ramesh);
            db.SaveChanges();
        }
    }
}
