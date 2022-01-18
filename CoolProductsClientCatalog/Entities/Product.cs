using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolProductsClientCatalog.Entities
{
    class Product
    {
      
            public int ProductID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Brand { get; set; }
            public bool InStock { get; set; }
            public object Catagory_CatagoryId { get; set; }
        }

    }

