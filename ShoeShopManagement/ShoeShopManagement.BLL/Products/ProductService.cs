using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Products
{
    public class ProductService :CrudService<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }

        public IQueryable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public void DeleteProduct(int ID)
        {
            _unitOfWork.SprocNonQuery("sp_DeleteProduct", new object[] { ID });
        }

        public Product GetByID(int ID)
        {
            return _repository.GetById(ID);
        }

        public void AddProduct(Product product)
        {
            _unitOfWork.SprocNonQuery("sp_AddProduct", new object[] { product.Name, product.Price, product.CategoryID, product.Description, product.TotalQuantity});
        }

        public void UpdateProduct(Product product)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateProduct", new object[] { product.ID, product.Name, product.Price, product.CategoryID, product.Description, product.TotalQuantity });
        }
    }
}
