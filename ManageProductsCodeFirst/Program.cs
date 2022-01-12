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

        //static void Show(string msg)
        //{
        //    Console.WriteLine(msg);
        //}

        static void Main(string[] args)
        {
            IProductsRepository repo = new ProductsRepository();

            Product p = new Product();
            repo.AddProduct(p);
           
        }
    }
}
