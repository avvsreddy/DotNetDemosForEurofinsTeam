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
            // insert a new product into database

            Product p = new Product { Name = "IPhone X", Price = 89000 };
            ProductsDBContext db = new ProductsDBContext();
            db.Products.Add(p);
            db.SaveChanges();

        }
    }
}
