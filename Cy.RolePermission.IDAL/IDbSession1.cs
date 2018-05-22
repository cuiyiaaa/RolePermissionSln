using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IDAL
{
	
	public partial interface IDbSession
    {
        IActionInfoRepository ActionInfoRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IBooksRepository BooksRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IkeyWordsRankRepository keyWordsRankRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        ILogRepository LogRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IMenuInfoRepository MenuInfoRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IR_UserInfo_ActionInfoRepository R_UserInfo_ActionInfoRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IRoleInfoRepository RoleInfoRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        ISearchDetailsRepository SearchDetailsRepository { get; set; }
    }   
	
	public partial interface IDbSession
    {
        IUserInfoRepository UserInfoRepository { get; set; }
    }   
}