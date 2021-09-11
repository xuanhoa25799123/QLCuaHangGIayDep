using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Report
{
    public interface ISalesReportService
    {
        SalesReportModel GetSalesReport();
        SalesReportModel GetSalesReportFromRemote();
        SalesReportModel GetSalesReportByDate(DateTime from, DateTime to);
        SalesReportModel GetSalesReportByDateFromRemote(DateTime from, DateTime to);
    }
}
