using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.Entities
{
    //[Table("Customers")]
    public class Customer : Person
    {
        public string CustType { get; set; }
        public int Credit { get; set; }
    }
}
