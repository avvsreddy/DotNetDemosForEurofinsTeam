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
        public DbSet<Catagory> Catatories { get; set; }

        public DbSet<Person> People { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            //modelBuilder.Entity<Product>().HasRequired(p => p.Name);

            // map to sp

            //modelBuilder.Entity<Customer>().MapToStoredProcedures();


            modelBuilder.Types().Configure(t => t.MapToStoredProcedures());

            // for Table-Per-Concrete classe inheritance mapping strategy
            // using only fluent API

            modelBuilder.Entity<Customer>().Map(c => { c.MapInheritedProperties(); c.ToTable("Customers"); });

            modelBuilder.Entity<Supplier>().Map(s => { s.MapInheritedProperties(); s.ToTable("Suppliers"); });



        }
    }
}
