using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Products
{
    public interface IProductService : ICrudService<Product>
    {
        IQueryable<Product> GetAll();
        void DeleteProduct(int ID);
        Product GetByID(int ID);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}
