using ManageProductsCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProductsCodeFirst.DataAccess
{
    public interface IProductsRepository
    {
        void AddProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();

    }
}
