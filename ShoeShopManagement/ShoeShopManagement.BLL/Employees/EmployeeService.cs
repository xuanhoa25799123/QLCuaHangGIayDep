using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Employees
{
    public class EmployeeService : CrudService<Employee>, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }

        public IList<Employee> GetAll()
        {
            return _unitOfWork.SprocQuery<Employee>("sp_GetAllEmployee", new object[] { });
        }

        public IList<Employee> GetAllFromRemote()
        {
            return _unitOfWork.SprocQuery<Employee>("LINK.ShoeShopManagement.[dbo].sp_GetAllEmployee", new object[] {});
        }

        public void AddEmployee(Employee employee)
        {
            _unitOfWork.SprocNonQuery("sp_AddEmployee", new object[] { employee.Name, employee.DateOfBirth, employee.Address, employee.PhoneNumber, employee.Position, employee.Salary, employee.BranchID});
        }

        public void AddEmployeeFromRemote(Employee employee)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_AddEmployee", new object[] { employee.Name, employee.DateOfBirth, employee.Address, employee.PhoneNumber, employee.Position, employee.Salary, employee.BranchID });
        }

        public void UpdateEmployee(Employee employee)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateEmployee", new object[] { employee.ID, employee.Name, employee.DateOfBirth, employee.Address, employee.PhoneNumber, employee.Position, employee.Salary, employee.BranchID });
        }

        public void UpdateEmployeeFromRemote(Employee employee)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_UpdateEmployee", new object[] { employee.ID, employee.Name, employee.DateOfBirth, employee.Address, employee.PhoneNumber, employee.Position, employee.Salary, employee.BranchID });
        }
        public void DeleteEmployee(int ID)
        {
            _unitOfWork.SprocNonQuery("sp_DeleteEmployee", new object[] { ID });
        }
        public void DeleteEmployeeFromRemote(int ID)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_DeleteEmployee", new object[] { ID });
        }
        
    }
}
