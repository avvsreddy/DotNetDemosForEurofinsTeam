using CoolProductsService.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoolProductsService.Controllers
{
    public class CoolProductsController : ApiController
    {
        private CoolProductsDbContext db = new CoolProductsDbContext();


        // GET: api/coolproducts - Return list of products

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }


        // GET: api/coolproducts/1 - return a product by product id

        // GET: api/coolproudcts/name/iphone x - return a product by name

        // GET: api/coolproducts/brand/apple - return all products by brand

        // GET: api/coolproducts/cheapest - return cheapest product

        // GET: api/coolproducts/costliest - return costliest product

        // GET: api/coolproducts/costbetween/40000/80000 - retur all products between min and max cost

        // GET: api/coolproudcts/instock - get all products in stock


    }
}
