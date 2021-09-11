using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Statistic
{
    public interface IProductStatisticService
    {
        IList<ProductStatisticModel> GetHotProduct();
        IList<ProductStatisticModel> GetHotProductFromRemote();
        IList<ProductStatisticModel> GetHotProductByDate(DateTime from, DateTime to);
        IList<ProductStatisticModel> GetHotProductByDateFromRemote(DateTime from, DateTime to);
        IList<ProductStatisticModel> GetMostSalesProduct();
        IList<ProductStatisticModel> GetMostSalesProductFromRemote();
        IList<ProductStatisticModel> GetMostSalesProductByDate(DateTime from, DateTime to);
        IList<ProductStatisticModel> GetMostSalesProductByDateFromRemote(DateTime from, DateTime to);

    }
}
