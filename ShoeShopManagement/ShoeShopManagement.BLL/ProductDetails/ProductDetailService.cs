using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.ProductDetails
{
    public class ProductDetailService : CrudService<ProductDetail>, IProductDetailService
    {
        public ProductDetailService(IUnitOfWork unitOfWork): base(unitOfWork)
        {

        }

        public IQueryable<ProductDetail> GetAll()
        {
            return _repository.GetAll();
        }

        public IList<ProductDetail> GetProductDetailByProduct(int productID)
        {
            return _unitOfWork.SprocQuery<ProductDetail>("sp_GetProductDetailByProduct", new object[] { productID });
        }

        public IList<ProductDetail> GetProductDetailByProductFromRemote(int productID)
        {
            return _unitOfWork.SprocQuery<ProductDetail>("LINK.ShoeShopManagement.[dbo].sp_GetProductDetailByProduct", new object[] { productID });
        }

        public void AddProductDetail(ProductDetail productDetail)
        {
            _unitOfWork.SprocNonQuery("sp_AddProductDetail", new object[] { productDetail.ProductID, productDetail.Size, productDetail.Quantity, productDetail.BranchID});
        }
        public void AddProductDetailFromRemote(ProductDetail productDetail)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_AddProductDetail", new object[] { productDetail.ProductID, productDetail.Size, productDetail.Quantity, productDetail.BranchID });
        }
        public void UpdateProductDetail(ProductDetail productDetail)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateProductDetail", new object[] {productDetail.ID, productDetail.ProductID, productDetail.Size, productDetail.Quantity});
        }
        public void UpdateProductDetailFromRemote(ProductDetail productDetail)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_UpdateProductDetail", new object[] { productDetail.ID, productDetail.ProductID, productDetail.Size, productDetail.Quantity });
        }

        public void UpdateProductQuantity(int quantity, int productID)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateProductQuantity", new object[] { quantity, productID });
        }

        public int? GetQuantityByProductID(int productID)
        {
            return _unitOfWork.SprocQuery<int?>("sp_GetQuantityByProductID", new object[] { productID }).FirstOrDefault();
        }
        public int? GetQuantityByProductIDFromRemote(int productID)
        {
            return _unitOfWork.SprocQuery<int?>("LINK.ShoeShopManagement.[dbo].sp_GetQuantityByProductID", new object[] { productID }).FirstOrDefault();
        }
        public void UpdateProductDetailQuantity(int quantity, int productID, string size)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateQuantityPD", new object[] { quantity, productID, size });
        }

        public void UpdateProductDetailQuantityFromRemote(int quantity, int productID, string size)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_UpdateQuantityPD", new object[] { quantity, productID, size });
        }
    }
}
