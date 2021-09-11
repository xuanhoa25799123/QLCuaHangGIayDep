using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Bills
{
    public interface IBillService: ICrudService<Bill>
    {
        IQueryable<Bill> GetAll();
        IList<Bill> GetAllFromRemote();
        void DeleteBill(int ID);
        void DeleteBillFromRemote(int ID);
        void AddBill(Bill bill);
    }
}
