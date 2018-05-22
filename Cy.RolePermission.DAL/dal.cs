 
using Cy.RolePermission.IDAL;
using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.DAL
{
	
	public partial class ActionInfoRepository : BaseRepository<ActionInfo>, IActionInfoRepository
    {
       
    }   
	
	public partial class BooksRepository : BaseRepository<Books>, IBooksRepository
    {
       
    }   
	
	public partial class keyWordsRankRepository : BaseRepository<keyWordsRank>, IkeyWordsRankRepository
    {
       
    }   
	
	public partial class LogRepository : BaseRepository<Log>, ILogRepository
    {
       
    }   
	
	public partial class MenuInfoRepository : BaseRepository<MenuInfo>, IMenuInfoRepository
    {
       
    }   
	
	public partial class R_UserInfo_ActionInfoRepository : BaseRepository<R_UserInfo_ActionInfo>, IR_UserInfo_ActionInfoRepository
    {
       
    }   
	
	public partial class RoleInfoRepository : BaseRepository<RoleInfo>, IRoleInfoRepository
    {
       
    }   
	
	public partial class SearchDetailsRepository : BaseRepository<SearchDetails>, ISearchDetailsRepository
    {
       
    }   
	
	public partial class UserInfoRepository : BaseRepository<UserInfo>, IUserInfoRepository
    {
       
    }   
}