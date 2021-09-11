using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("BillDetail")]
    public class BillDetail : IEntity
    {
        public int ID { get; set; }

        [Required]
        public int BillID { get; set; }

        [Required]
        public int ProductID { get; set; }

        public int CurrentUnitPrice { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Quantity { get; set; }

        

        [NotMapped]
        public int IntoMoney => (int)(Quantity * CurrentUnitPrice);
        
        public bool State { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}
