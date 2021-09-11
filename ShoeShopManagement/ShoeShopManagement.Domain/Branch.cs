using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("Branch")]
    public class Branch : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Branch()
        {
            ProductDetails = new HashSet<ProductDetail>();
            Employees = new HashSet<Employee>();
        }
    }
}
