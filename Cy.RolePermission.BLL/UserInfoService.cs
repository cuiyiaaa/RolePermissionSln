using Cy.RolePermission.IBLL;
using Cy.RolePermission.Model;
using System.Linq;

namespace Cy.RolePermission.BLL
{
    public partial class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        /// <summary>
        /// 校验登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserInfo ValidateUser(string userName,string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return null;
            return this.GetAllEntity(u => u.Name == userName && u.Pwd == password).FirstOrDefault();
        }
    }
}
