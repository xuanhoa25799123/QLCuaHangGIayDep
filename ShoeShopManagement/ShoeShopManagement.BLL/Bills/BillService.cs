using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Bills
{
    public class BillService : CrudService<Bill>, IBillService
    {
        public BillService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IQueryable<Bill> GetAll()
        {
            return this._repository.GetAll();
        }

        public IList<Bill> GetAllFromRemote()
        {
            return _unitOfWork.SprocQuery<Bill>("LINK.ShoeShopManagement.[dbo].sp_GetAllBill", new object[] { });
        }
        public void DeleteBill(int ID)
        {
            _unitOfWork.SprocNonQuery("sp_DeleteBill", new object[] { ID });
        }
        public void DeleteBillFromRemote(int ID)
        {
            _unitOfWork.SprocNonQuery("LINK.ShoeShopManagement.[dbo].sp_DeleteBill", new object[] { ID });
        }
        public void AddBill(Bill bill)
        {
            _unitOfWork.SprocNonQuery("sp_AddBill", new object[] { bill.EmployeeID, bill.CustomerName, bill.PhoneNumber, bill.CheckoutDate, bill.Total, bill.Discount });
        }
    }
}
