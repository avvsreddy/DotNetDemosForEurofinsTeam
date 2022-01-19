using CoolProductsService.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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

        // GET: api/coolproducts/async/1 - return a product by product id

        [Route("async/{pid}")]
        public async Task<IHttpActionResult> GetProductByIdAsync(int pid)
        {
            var p = await db.Products.FindAsync(pid);
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



        // Versioning of API
        // URI
        // Query String
        // Custom Headers
        // Accept Headers



        // www.domainname.com/api/coorproducts/v2/isavailable
        [Route("v2/isavailable")]
        public IHttpActionResult GetAvailableProducts()
        {
            var products = (from p in db.Products
                            where p.InStock
                            select p).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        // DELETE api/coolproducts/1
        [HttpDelete]
        public IHttpActionResult DeleteProductById(int id)
        {
            var productToDelete = db.Products.Find(id);
            if (productToDelete == null)
                return NotFound();

            db.Products.Remove(productToDelete);
            db.SaveChanges();
            return Ok();
        }


        // POST  api/coolproducts
        [HttpPost]
        public IHttpActionResult SaveProduct(Product productToSave)
        {
            // validate the input
            // if(productToSave.Name == null)

            if (!ModelState.IsValid)
                return BadRequest("Invalid product details");

            // save the data
            db.Products.Add(productToSave);
            db.SaveChanges();

            // return a status code  201 with location/uri of the product and its data
            return Created($"api/coolproducts/{productToSave.ProductID}",productToSave);

        }

        // POST  api/coolproducts/async
        [HttpPost]
        [Route("async")]
        public async  Task<IHttpActionResult> SaveProductAsync(Product productToSave)
        {
            // validate the input
            // if(productToSave.Name == null)

            if (!ModelState.IsValid)
                return BadRequest("Invalid product details");

            // save the data
            db.Products.Add(productToSave);
            await db.SaveChangesAsync();

            // return a status code  201 with location/uri of the product and its data
            return Created($"api/coolproducts/{productToSave.ProductID}", productToSave);

        }


        // PUT api/coorproducts
        [HttpPut]
        public IHttpActionResult EditProduct(Product productToEdit)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid product details... can not edit the product");

            //var p = db.Products.Find(productToEdit.ProductID);
            //if (p == null)
            //    return NotFound();

            db.Entry(productToEdit).State = System.Data.Entity.EntityState.Modified;
            int count = db.SaveChanges();
            if (count > 0) return Ok(productToEdit); else return NotFound();

        }


    }
}
