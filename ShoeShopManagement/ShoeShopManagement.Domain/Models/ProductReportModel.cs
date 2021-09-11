using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain.Models
{
    public class ProductReportModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }

        public int IntoMoney { get; set; }
        public int Price { get; set; }
    }
}
