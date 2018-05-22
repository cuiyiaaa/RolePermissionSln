 
using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IDAL
{
	
	public partial interface IActionInfoRepository : IBaseRepository<ActionInfo>
    {
       
    }   
	
	public partial interface IBooksRepository : IBaseRepository<Books>
    {
       
    }   
	
	public partial interface IkeyWordsRankRepository : IBaseRepository<keyWordsRank>
    {
       
    }   
	
	public partial interface ILogRepository : IBaseRepository<Log>
    {
       
    }   
	
	public partial interface IMenuInfoRepository : IBaseRepository<MenuInfo>
    {
       
    }   
	
	public partial interface IR_UserInfo_ActionInfoRepository : IBaseRepository<R_UserInfo_ActionInfo>
    {
       
    }   
	
	public partial interface IRoleInfoRepository : IBaseRepository<RoleInfo>
    {
       
    }   
	
	public partial interface ISearchDetailsRepository : IBaseRepository<SearchDetails>
    {
       
    }   
	
	public partial interface IUserInfoRepository : IBaseRepository<UserInfo>
    {
       
    }   
}