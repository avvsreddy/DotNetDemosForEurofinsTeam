using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.Entities
{
    //[Table("tbl_items")]
    public class Product
    {
        //[Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }
        //[Column("cost")]
        public int Price { get; set; }

        public string Brand { get; set; }

        public bool InStock { get; set; }

        public virtual Catagory Catagory { get; set; }

        public virtual List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}
