using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Accounts
{
    public interface IAccountService
    {
        IList<AccountModel> GetAllAccount();
        void DeleteAccount(string ID, string loginName);
        void AddAccount(string loginName, int userName, string role);
        void ResetPassword(string loginName);
    }
}
