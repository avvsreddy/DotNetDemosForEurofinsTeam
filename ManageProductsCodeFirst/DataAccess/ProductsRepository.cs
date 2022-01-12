using ManageProductsCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {

        private ProductsDBContext db = new ProductsDBContext();
        public void AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public void UpdateProduct(Product p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
