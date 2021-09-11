using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("Bill")]
    public class Bill : IEntity
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CheckoutDate { get; set; }

        public double Discount { get; set; }

        public int Total { get; set; }

        public bool State { get; set; }

        public virtual Employee Employee { get; set; }

        public ICollection<BillDetail> BillDetail { get; set; }

        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
        }
    }
}
