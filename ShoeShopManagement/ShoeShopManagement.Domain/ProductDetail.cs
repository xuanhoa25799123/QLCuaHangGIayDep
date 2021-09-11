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
    [Table("ProductDetail")]
    public class ProductDetail: IEntity
    {
        public int ID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int BranchID { get; set; }

        public string Size { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Quantity { get; set; }

        public virtual  Product Product { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
