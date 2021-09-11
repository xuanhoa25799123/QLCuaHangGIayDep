using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain.Models
{
    public class EmployeeStatisticModel
    {
        public string Name { get; set; }
        public int TotalBill { get; set; }
        public int TotalMoney { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
