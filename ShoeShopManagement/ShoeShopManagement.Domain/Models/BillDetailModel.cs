using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain.Models
{
    public class BillDetailModel
    {
        public int ID { get; set; }

        public int BillID { get; set; }

        public int ProductID { get; set; }

        public int CurrentUnitPrice { get; set; }

        public int Quantity { get; set; }

        public int IntoMoney => (int)(Quantity * CurrentUnitPrice);

        public bool State { get; set; }

        public string Name { get; set; }
    }
}
