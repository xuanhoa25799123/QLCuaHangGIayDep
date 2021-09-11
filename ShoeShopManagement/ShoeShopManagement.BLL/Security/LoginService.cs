using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Security
{
    public class LoginService : CrudService<LoginModel>, IAuthenticateService
    {
        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public LoginModel GetLoginInfo(string loginName)
        {
            return _unitOfWork.SprocQuery<LoginModel>("sp_GetLoginInfo", new object[] { loginName }).FirstOrDefault();
        }
    }
}
