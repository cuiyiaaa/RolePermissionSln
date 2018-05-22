using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IBLL
{
    public partial interface IUserInfoService:IBaseService<UserInfo>
    {
        UserInfo ValidateUser(string userName, string password);
    }
}
