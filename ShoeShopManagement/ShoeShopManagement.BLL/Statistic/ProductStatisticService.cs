using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Statistic
{
    public class ProductStatisticService: CrudService<ProductStatisticModel>, IProductStatisticService
    {
        public ProductStatisticService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<ProductStatisticModel> GetHotProduct()
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("sp_SPBanChay", new object[] { });
        }
        public IList<ProductStatisticModel> GetHotProductFromRemote()
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_SPBanChay", new object[] { });
        }
        public IList<ProductStatisticModel> GetHotProductByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("sp_SPBanChayTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month,from.Year,to.Year });
        }
        public IList<ProductStatisticModel> GetHotProductByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_SPBanChayTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<ProductStatisticModel> GetMostSalesProduct()
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("sp_SPDoanhThuCao", new object[] { });
        }
        public IList<ProductStatisticModel> GetMostSalesProductFromRemote()
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_SPDoanhThuCao", new object[] { });
        }
        public IList<ProductStatisticModel> GetMostSalesProductByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("sp_SPDoanhThuCaoTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<ProductStatisticModel> GetMostSalesProductByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_SPDoanhThuCaoTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
    }
}
