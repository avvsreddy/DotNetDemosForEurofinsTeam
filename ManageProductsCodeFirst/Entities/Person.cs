using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.Entities
{
   
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // for TPC
        public int PersonID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
    }
}
