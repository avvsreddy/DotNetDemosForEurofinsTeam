using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.Entities
{
    [ComplexType]
    public class Address
    {
        public string Area { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
