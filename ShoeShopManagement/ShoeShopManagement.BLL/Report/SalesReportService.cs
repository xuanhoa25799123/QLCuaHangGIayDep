using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Report
{
    public class SalesReportService: CrudService<SalesReportModel>, ISalesReportService
    {
        public SalesReportService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public SalesReportModel GetSalesReport()
        {
            return _unitOfWork.SprocQuery<SalesReportModel>("sp_DoanhThu", new object[] { }).FirstOrDefault();
        }
        public SalesReportModel GetSalesReportFromRemote()
        {
            return _unitOfWork.SprocQuery<SalesReportModel>("LINK.ShoeShopManagement.[dbo].sp_DoanhThu", new object[] { }).FirstOrDefault();
        }
        public SalesReportModel GetSalesReportByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<SalesReportModel>("sp_DoanhThuTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year }).FirstOrDefault();
        }
        public SalesReportModel GetSalesReportByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<SalesReportModel>("LINK.ShoeShopManagement.[dbo].sp_DoanhThuTheoThang", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year }).FirstOrDefault();
        }
    }
}
