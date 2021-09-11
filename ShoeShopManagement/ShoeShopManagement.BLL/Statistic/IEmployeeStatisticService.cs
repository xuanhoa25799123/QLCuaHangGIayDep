using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Statistic
{
    public interface IEmployeeStatisticService
    {
        IList<EmployeeStatisticModel> GetMostSellEmployee();
        IList<EmployeeStatisticModel> GetMostSellEmployeeFromRemote();
        IList<EmployeeStatisticModel> GetMostSellEmployeeByDate(DateTime from, DateTime to);
        IList<EmployeeStatisticModel> GetMostSellEmployeeByDateFromRemote(DateTime from, DateTime to);
        IList<EmployeeStatisticModel> GetNoSellEmployee();
        IList<EmployeeStatisticModel> GetNoSellEmployeeFromRemote();
        IList<EmployeeStatisticModel> GetNoSellEmployeeByDate(DateTime from, DateTime to);
        IList<EmployeeStatisticModel> GetNoSellEmployeeByDateFromRemote(DateTime from, DateTime to);
    }
}
