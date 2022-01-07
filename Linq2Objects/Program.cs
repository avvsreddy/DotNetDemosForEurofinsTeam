using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1: Get All Products whose price is more than 80k
            ProductsRepository repo = new ProductsRepository();
            var result1 = from p in repo.GetProducts()
                          where p.Price >= 80000
                          select p;
            //todo: get with extention methods


            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Name}\t{item.Price}");
            }

            // Example 2: Get all products in stock
            var result2 = repo.GetProducts().Where(p => p.InStock);
            result2 = from p in repo.GetProducts()
                      where p.InStock == true
                      select p;

            // Example 3: Get only the name of all products
            var result3 = from p in repo.GetProducts()
                          select p.Name;

            //todo: get with extention methods


            // Lab 4: Get only the name and price of all the products

            // Lab 5: Get total price of all the products in stock

            // Lab 6: Get total count of all the prudcts whose price is less than 50k

            // Lab 7: Get Name of the product and Name of the catagory

            // Lab 8: Get all the products belogns to Laptops catagory

            // Lab 9: Get all the products total price belogs to mobiels

            // Lab 10: Get all the products average price belongs to Apple brand



        }
    }


    class ProductsRepository
    {
        public List<Product> GetProducts()
        {

            Catagory c1 = new Catagory { CatagoryId = 1, Name = "Mobiels" };
            Catagory c2 = new Catagory { CatagoryId = 2, Name = "Laptops" };
            Catagory c3 = new Catagory { CatagoryId = 3, Name = "Watches" };

            List<Product> plist = new List<Product>
            {
                new Product{ProductID=111, Name="IPhone X", Price = 78000, InStock=true, Brand="Apple", Catagory = c1 },
                new Product{ProductID=212, Name="IPhone XI", Price = 88000, InStock=true, Brand="Apple", Catagory = c1 },
                new Product{ProductID=222, Name="IWatch X", Price = 48000, InStock=true, Brand="Apple", Catagory = c3 },
                new Product{ProductID=311, Name="Galaxy Gear", Price = 68000, InStock=true, Brand="Samsung", Catagory = c3 },
                new Product{ProductID=131, Name="Dell XPS 6", Price = 78000, InStock=true, Brand="Dell", Catagory = c2 },
                new Product{ProductID=113, Name="HP Pavilion 3", Price = 56000, InStock=true, Brand="HP", Catagory = c2 },

            };
            return plist;
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string Brand { get; set; }
        public Catagory Catagory { get; set; }
    }

    class Catagory
    {
        public int CatagoryId { get; set; }
        public string Name { get; set; }
    }
}
