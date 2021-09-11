using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.ProductDetails
{
    public interface IProductDetailService : ICrudService<ProductDetail>
    {
        IQueryable<ProductDetail> GetAll();
        IList<ProductDetail> GetProductDetailByProduct(int productID);
        IList<ProductDetail> GetProductDetailByProductFromRemote(int productID);
        void AddProductDetail(ProductDetail productDetail);
        void AddProductDetailFromRemote(ProductDetail productDetail);
        void UpdateProductDetail(ProductDetail productDetail);
        void UpdateProductDetailFromRemote(ProductDetail productDetail);
        void UpdateProductQuantity(int quantity, int productID);
        int? GetQuantityByProductID(int productID);
        int? GetQuantityByProductIDFromRemote(int productID);
        void UpdateProductDetailQuantity(int quantity, int productID, string size);
        void UpdateProductDetailQuantityFromRemote(int quantity, int productID, string size);
    }
}
