using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.Domain
{
    [Table("Employee")]
    public class Employee : IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public bool State { get; set; }

        public int BranchID { get; set; }

        public virtual Branch Branch { get; set; }

        public ICollection<Bill> Bills { get; set; }

        public Employee()
        {
            Bills = new HashSet<Bill>();
        }
    }
}
