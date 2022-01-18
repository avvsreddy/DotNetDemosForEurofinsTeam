using CoolProductsService.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoolProductsService.Controllers
{

    [RoutePrefix("api/coolproducts")]
    public class CoolProductsController : ApiController
    {
        private CoolProductsDbContext db = new CoolProductsDbContext();


        // GET: api/coolproducts - Return list of products

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }


        // GET: api/coolproducts/1 - return a product by product id

        public IHttpActionResult GetProductById(int id)
        {
            var p = db.Products.Find(id);
            if (p == null)
                return NotFound();
            return Ok(p);
        }

        // GET: api/coolproudcts/name/iphone x - return a product by name

        [Route("name/{pname}")]
        public IHttpActionResult GetProductByName(string pname)
        {
            if (string.IsNullOrEmpty(pname))
                return BadRequest();
            var plist = from p in db.Products
                        where p.Name.Contains(pname)
                        select p;
            if (plist.ToList().Count == 0)
                return NotFound();
            return Ok(plist);
        }

        // GET: api/coolproducts/brand/apple - return all products by brand
        [Route("brand/{brand}")]
        public IHttpActionResult GetProductsByBrand(string brand)
        {
            if (string.IsNullOrEmpty(brand))
                return BadRequest();
            var plist = from p in db.Products
                        where p.Brand.Contains(brand)
                        select p;
            if (plist.ToList().Count == 0)
                return NotFound();
            return Ok(plist);
        }



        // GET: api/coolproducts/cheapest - return cheapest product

        [Route("cheapest")]
        public IHttpActionResult GetCheapestProduct()
        {
            var plist = from p in db.Products
                        orderby p.Price 
                        select p;
            var product = plist.FirstOrDefault();

            var cheapestProducts = from prod in plist
                                    where prod.Price == product.Price
                                    select prod;

            return Ok(cheapestProducts.ToList());
        }

        // GET: api/coolproducts/costliest - return costliest product

        [Route("costliest")]
        public IHttpActionResult GetConstliestProduct()
        {
            var plist = from p in db.Products
                        orderby p.Price descending
                        select p;
            var product = plist.FirstOrDefault();

            var costliestProducts = from prod in plist
                                    where prod.Price == product.Price
                                    select prod;

            return Ok(costliestProducts.ToList()); 
        }

        // GET: api/coolproducts/costbetween/40000/80000 - retur all products between min and max cost

        [Route("costbetween/{min}/{max}")]
        public IHttpActionResult GetProductsByPriceRange(int min, int max)
        {
            var products = (from p in db.Products
                           where p.Price >= min && p.Price <= max
                           select p).ToList();
            if (products.Count == 0)
                return NotFound();

            return Ok(products);
        }


        // GET: api/coolproudcts/instock - get all products in stock

        [Route("instock")]
        public IHttpActionResult GetProductsInStock()
        {
            var products = (from p in db.Products
                            where p.InStock
                            select p).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
    }
}
