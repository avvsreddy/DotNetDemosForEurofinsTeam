using ManageProductsCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.DataAccess
{
    public class ProductsDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
