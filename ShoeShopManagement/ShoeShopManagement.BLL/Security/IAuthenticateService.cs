using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Security
{
    public interface IAuthenticateService
    {
        LoginModel GetLoginInfo(string loginName);
    }
}
