using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Employees
{
    public interface IEmployeeService : ICrudService<Employee>
    {
        IList<Employee> GetAll();
        IList<Employee> GetAllFromRemote();
        void AddEmployee(Employee employee);
        void AddEmployeeFromRemote(Employee employee);
        void UpdateEmployee(Employee employee);
        void UpdateEmployeeFromRemote(Employee employee);
        void DeleteEmployee(int ID);
        void DeleteEmployeeFromRemote(int ID);
        
    }
}
