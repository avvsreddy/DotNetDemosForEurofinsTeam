using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CoolProductsService.Models.DataAccess
{
    public partial class CoolProductsDbContext : DbContext
    {
        public CoolProductsDbContext()
            : base("name=CoolProductsDbContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
