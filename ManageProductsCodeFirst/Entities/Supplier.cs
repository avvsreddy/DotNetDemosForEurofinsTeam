using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.Entities
{
    //[Table("Suppliers")]
    public class Supplier : Person
    {
        public int Rating { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
