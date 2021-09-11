using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Statistic
{
    public interface ICustomerStatisticService
    {
        IList<CustomerStatisticModel> GetMostBuyCustomer();
        IList<CustomerStatisticModel> GetMostBuyCustomerFromRemote();
        IList<CustomerStatisticModel> GetMostBuyCustomerByDate(DateTime from, DateTime to);
        IList<CustomerStatisticModel> GetMostBuyCustomerByDateFromRemote(DateTime from, DateTime to);
    }
}
