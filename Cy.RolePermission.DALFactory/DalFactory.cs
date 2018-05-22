using Cy.RolePermission.IDAL;
using Cy.RolePermission.Ioc;


namespace Cy.RolePermission.DALFactory
{
	public partial class DalFactory
	{
		 public static IActionInfoRepository GetActionInfoRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IActionInfoRepository>("ActionInfoRepository");
			}
		 }
	
		 public static IBooksRepository GetBooksRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IBooksRepository>("BooksRepository");
			}
		 }
	
		 public static IkeyWordsRankRepository GetkeyWordsRankRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IkeyWordsRankRepository>("keyWordsRankRepository");
			}
		 }
	
		 public static ILogRepository GetLogRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<ILogRepository>("LogRepository");
			}
		 }
	
		 public static IMenuInfoRepository GetMenuInfoRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IMenuInfoRepository>("MenuInfoRepository");
			}
		 }
	
		 public static IR_UserInfo_ActionInfoRepository GetR_UserInfo_ActionInfoRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IR_UserInfo_ActionInfoRepository>("R_UserInfo_ActionInfoRepository");
			}
		 }
	
		 public static IRoleInfoRepository GetRoleInfoRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IRoleInfoRepository>("RoleInfoRepository");
			}
		 }
	
		 public static ISearchDetailsRepository GetSearchDetailsRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<ISearchDetailsRepository>("SearchDetailsRepository");
			}
		 }
	
		 public static IUserInfoRepository GetUserInfoRepository
		 {
		   get
			{
			 return SpringHelper.GetObject<IUserInfoRepository>("UserInfoRepository");
			}
		 }
	}
}