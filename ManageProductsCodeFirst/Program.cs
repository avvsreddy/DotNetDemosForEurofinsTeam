using ManageProductsCodeFirst.DataAccess;
using ManageProductsCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsDBContext db = new ProductsDBContext();

            // create a new catagory
            //Catagory c = new Catagory { Name = "Smart Phones" };
            //db.Catatories.Add(c);
            //db.SaveChanges();

            // add a new product to smart phones catagory

            var catagory = (from c in db.Catatories
                            where c.Name == "Smart Phones"
                            select c).FirstOrDefault();


            Product p = new Product { Name = "Appo X", Brand = "Appo", Price = 45000, InStock = true, Catatory = catagory };

            db.Products.Add(p);
            db.SaveChanges();


           // Lab 1: insert new product with new catagory
           // Lab 2: update iphone product with smart phones catagory
           // Lab 3: insert a new catagory called smart whates and update the iwatch with that catagory
           // extract and display product name and catagory name only
           // find the total count of all produts belongs to smart phones
           // find the costliest smart watch
           // find the total cost of all laptops




        }
    }
}
