using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ManageContactsDBFirst.DataAccess
{
    public partial class ContactsEDMModel : DbContext
    {
        public ContactsEDMModel()
            : base("name=ContactsEDMModel")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Mobile)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Location)
                .IsFixedLength();
        }
    }
}
