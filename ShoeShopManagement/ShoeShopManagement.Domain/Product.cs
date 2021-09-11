using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("Product")]
    public class Product : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public int TotalQuantity { get; set; }

        public bool State { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }

        public Product()
        {
            ProductDetails = new HashSet<ProductDetail>();
            BillDetails = new HashSet<BillDetail>();
        }
    }
}
