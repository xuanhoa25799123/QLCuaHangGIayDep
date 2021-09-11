using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("Category")]
    public class Category : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Parent_ID { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
