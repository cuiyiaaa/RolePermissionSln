using Cy.RolePermission.IBLL;
using Cy.RolePermission.IDAL;
using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.BLL
{
	
	public partial class ActionInfoService : BaseService<ActionInfo>,IActionInfoService
    {
       
    }   
	
	public partial class BooksService : BaseService<Books>,IBooksService
    {
       
    }   
	
	public partial class keyWordsRankService : BaseService<keyWordsRank>,IkeyWordsRankService
    {
       
    }   
	
	public partial class LogService : BaseService<Log>,ILogService
    {
       
    }   
	
	public partial class MenuInfoService : BaseService<MenuInfo>,IMenuInfoService
    {
       
    }   
	
	public partial class R_UserInfo_ActionInfoService : BaseService<R_UserInfo_ActionInfo>,IR_UserInfo_ActionInfoService
    {
       
    }   
	
	public partial class RoleInfoService : BaseService<RoleInfo>,IRoleInfoService
    {
       
    }   
	
	public partial class SearchDetailsService : BaseService<SearchDetails>,ISearchDetailsService
    {
       
    }   
	
	public partial class UserInfoService : BaseService<UserInfo>,IUserInfoService
    {
       
    }   
}