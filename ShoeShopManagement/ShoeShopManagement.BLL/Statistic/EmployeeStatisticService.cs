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
    public class EmployeeStatisticService: CrudService<EmployeeStatisticModel>, IEmployeeStatisticService
    {
        public EmployeeStatisticService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<EmployeeStatisticModel> GetMostSellEmployee()
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("sp_NVBanNhieuHang", new object[] { });
        }
        public IList<EmployeeStatisticModel> GetMostSellEmployeeFromRemote()
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_NVBanNhieuHang", new object[] { });
        }
        public IList<EmployeeStatisticModel> GetMostSellEmployeeByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("sp_NVBanNhieuHangTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<EmployeeStatisticModel> GetMostSellEmployeeByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_NVBanNhieuHangTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<EmployeeStatisticModel> GetNoSellEmployee()
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("sp_NVKhongBanDuocHang", new object[] { });
        }
        public IList<EmployeeStatisticModel> GetNoSellEmployeeFromRemote()
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_NVKhongBanDuocHang", new object[] { });
        }
        public IList<EmployeeStatisticModel> GetNoSellEmployeeByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("sp_NVKhongBanDuocHangTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<EmployeeStatisticModel> GetNoSellEmployeeByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<EmployeeStatisticModel>("LINK.ShoeShopManagement.[dbo].sp_NVKhongBanDuocHangTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
    }
}
