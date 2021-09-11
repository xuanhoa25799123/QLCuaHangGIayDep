using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Accounts
{
    public class AccountService : CrudService<AccountModel>, IAccountService
    {
        public AccountService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public IList<AccountModel> GetAllAccount()
        {
            return _unitOfWork.SprocQuery<AccountModel>("sp_GetAllAccount", new object[] { });
        }

        public void DeleteAccount(string ID, string loginName)
        {
            _unitOfWork.SprocNonQuery("sp_DeleteAccount", new object[] { ID, loginName });
        }

        public void AddAccount(string loginName, int userName, string role)
        {
            _unitOfWork.SprocNonQuery("sp_TaoTaiKhoan", new object[] { loginName, "123456" , userName , role });
        }

        public void ResetPassword(string loginName)
        {
            _unitOfWork.SprocNonQuery("sp_ResetPassword", new object[] { loginName });
        }
    }
}
