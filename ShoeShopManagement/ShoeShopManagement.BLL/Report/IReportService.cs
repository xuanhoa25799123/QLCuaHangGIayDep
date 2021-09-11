using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Report
{
    public interface IReportService
    {
        IList<ProductReportModel> GetProductReport();
        IList<ProductReportModel> GetProductReportFromRemote();
        IList<ProductReportModel> GetProductReportByDate(DateTime from, DateTime to);
        IList<ProductReportModel> GetProductReportByDateFromRemote(DateTime from, DateTime to);
        IList<ProductReportModel> GetProductEmpty(int soLuong);
        IList<ProductReportModel> GetProductEmptyFromRemote(int soLuong);
    }
}
