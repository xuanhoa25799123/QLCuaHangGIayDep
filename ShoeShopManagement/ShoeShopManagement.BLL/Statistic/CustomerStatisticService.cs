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
    public class CustomerStatisticService : CrudService<CustomerStatisticModel>, ICustomerStatisticService
    {
        public CustomerStatisticService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<CustomerStatisticModel> GetMostBuyCustomer()
        {
            return _unitOfWork.SprocQuery<CustomerStatisticModel>("sp_KHMuaNhieu", new object[] { });
        }
        public IList<CustomerStatisticModel> GetMostBuyCustomerFromRemote()
        {
            return _unitOfWork.SprocQuery<CustomerStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_KHMuaNhieu", new object[] { });
        }
        public IList<CustomerStatisticModel> GetMostBuyCustomerByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<CustomerStatisticModel>("sp_KHMuaNhieuTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<CustomerStatisticModel> GetMostBuyCustomerByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<CustomerStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_KHMuaNhieuTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
    }
}
