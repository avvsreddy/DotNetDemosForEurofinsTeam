using CoolProductsClientCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoolProductsClientCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Discover the API Endpoint
            // http://localhost:60905/api/coolproducts/instock
            ShowAllProductsInStock();


        }


        public static void ShowAllProductsInStock()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("http://localhost:60905/api/v2/coolproducts/instock").Result;
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<Product> products = response.Content.ReadAsAsync<List<Product>>().Result;

                foreach (var item in products)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price);
                }
            }
            else
                Console.WriteLine("No Products in stock");
        }
    }
}
