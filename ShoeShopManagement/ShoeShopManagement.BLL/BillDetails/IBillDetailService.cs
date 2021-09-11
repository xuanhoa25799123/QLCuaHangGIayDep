using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.BillDetails
{
    public interface IBillDetailService: ICrudService<BillDetail>
    {
        IList<BillDetailModel> GetBillDetailByBill(int BillID);
        IList<BillDetailModel> GetBillDetailByBillRemote(int BillID);
        Bill GetBillByID(int BillID);
        Bill GetBillByIDFromRemote(int BillID);
        void AddBillDetail(BillDetail billDetail);
    }
}
