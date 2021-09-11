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
    public class ReportService : CrudService<ProductReportModel>, IReportService
    {
        public ReportService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public IList<ProductReportModel> GetProductReport()
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("sp_DSMatHangDaBan", new object[] { });
        }

        public IList<ProductReportModel> GetProductReportFromRemote()
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("LINK.ShoeShopManagement.[dbo].sp_DSMatHangDaBan", new object[] { });
        }

        public IList<ProductReportModel> GetProductReportByDate(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("sp_DSMatHangDaBanTheoNgay", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year});
        }

        public IList<ProductReportModel> GetProductReportByDateFromRemote(DateTime from, DateTime to)
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("LINK.ShoeShopManagement.[dbo].sp_DSMatHangDaBanTheoNgay", new object[] { from.Day, to.Day, from.Month, to.Month, from.Year, to.Year });
        }
        public IList<ProductReportModel> GetProductEmpty(int soLuong)
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("sp_SPGanHet", new object[] { soLuong });
        }
        public IList<ProductReportModel> GetProductEmptyFromRemote(int soLuong)
        {
            return _unitOfWork.SprocQuery<ProductReportModel>("LINK.ShoeShopManagement.[dbo].sp_SPGanHet", new object[] { soLuong });
        }
    }
}
