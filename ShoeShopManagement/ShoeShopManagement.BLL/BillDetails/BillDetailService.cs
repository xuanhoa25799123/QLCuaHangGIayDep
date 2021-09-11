using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.BillDetails
{
    public class BillDetailService: CrudService<BillDetail>, IBillDetailService
    {
        public BillDetailService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IList<BillDetailModel> GetBillDetailByBill(int BillID)
        {
            return _unitOfWork.SprocQuery<BillDetailModel>("sp_GetBillDetailByBill", new object[] { BillID });
        }

        public IList<BillDetailModel> GetBillDetailByBillRemote(int BillID)
        {
            return _unitOfWork.SprocQuery<BillDetailModel>("LINK.ShoeShopManagement.[dbo].sp_GetBillDetailByBill", new object[] { BillID });
        }

        public Bill GetBillByID(int BillID)
        {
            return _unitOfWork.SprocScalar<Bill>("sp_GetBillByID", new object[] { BillID });
        }
        public Bill GetBillByIDFromRemote(int BillID)
        {
            return _unitOfWork.SprocScalar<Bill>("LINK.ShoeShopManagement.[dbo].sp_GetBillByID", new object[] { BillID });
        }

        public void AddBillDetail(BillDetail billDetail)
        {
            _unitOfWork.SprocNonQuery("sp_AddBillDetail", new object[] { billDetail.BillID, billDetail.ProductID, billDetail.CurrentUnitPrice, billDetail.Quantity, billDetail.IntoMoney});
        }
    }
}
