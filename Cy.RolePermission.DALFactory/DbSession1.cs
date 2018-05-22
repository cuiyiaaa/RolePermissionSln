using Cy.RolePermission.DAL;
using Cy.RolePermission.IDAL;
using System.Data.Entity;

namespace Cy.RolePermission.DALFactory
{
	public partial class DbSession:IDbSession
    {
	
		public IActionInfoRepository _ActionInfoRepository;
        public IActionInfoRepository ActionInfoRepository
        {
            get
            {
                if (_ActionInfoRepository==null)
                {
                    _ActionInfoRepository = DalFactory.GetActionInfoRepository;
                }
                return _ActionInfoRepository;
            }
            set { _ActionInfoRepository = value; }
        }
	
		public IBooksRepository _BooksRepository;
        public IBooksRepository BooksRepository
        {
            get
            {
                if (_BooksRepository==null)
                {
                    _BooksRepository = DalFactory.GetBooksRepository;
                }
                return _BooksRepository;
            }
            set { _BooksRepository = value; }
        }
	
		public IkeyWordsRankRepository _keyWordsRankRepository;
        public IkeyWordsRankRepository keyWordsRankRepository
        {
            get
            {
                if (_keyWordsRankRepository==null)
                {
                    _keyWordsRankRepository = DalFactory.GetkeyWordsRankRepository;
                }
                return _keyWordsRankRepository;
            }
            set { _keyWordsRankRepository = value; }
        }
	
		public ILogRepository _LogRepository;
        public ILogRepository LogRepository
        {
            get
            {
                if (_LogRepository==null)
                {
                    _LogRepository = DalFactory.GetLogRepository;
                }
                return _LogRepository;
            }
            set { _LogRepository = value; }
        }
	
		public IMenuInfoRepository _MenuInfoRepository;
        public IMenuInfoRepository MenuInfoRepository
        {
            get
            {
                if (_MenuInfoRepository==null)
                {
                    _MenuInfoRepository = DalFactory.GetMenuInfoRepository;
                }
                return _MenuInfoRepository;
            }
            set { _MenuInfoRepository = value; }
        }
	
		public IR_UserInfo_ActionInfoRepository _R_UserInfo_ActionInfoRepository;
        public IR_UserInfo_ActionInfoRepository R_UserInfo_ActionInfoRepository
        {
            get
            {
                if (_R_UserInfo_ActionInfoRepository==null)
                {
                    _R_UserInfo_ActionInfoRepository = DalFactory.GetR_UserInfo_ActionInfoRepository;
                }
                return _R_UserInfo_ActionInfoRepository;
            }
            set { _R_UserInfo_ActionInfoRepository = value; }
        }
	
		public IRoleInfoRepository _RoleInfoRepository;
        public IRoleInfoRepository RoleInfoRepository
        {
            get
            {
                if (_RoleInfoRepository==null)
                {
                    _RoleInfoRepository = DalFactory.GetRoleInfoRepository;
                }
                return _RoleInfoRepository;
            }
            set { _RoleInfoRepository = value; }
        }
	
		public ISearchDetailsRepository _SearchDetailsRepository;
        public ISearchDetailsRepository SearchDetailsRepository
        {
            get
            {
                if (_SearchDetailsRepository==null)
                {
                    _SearchDetailsRepository = DalFactory.GetSearchDetailsRepository;
                }
                return _SearchDetailsRepository;
            }
            set { _SearchDetailsRepository = value; }
        }
	
		public IUserInfoRepository _UserInfoRepository;
        public IUserInfoRepository UserInfoRepository
        {
            get
            {
                if (_UserInfoRepository==null)
                {
                    _UserInfoRepository = DalFactory.GetUserInfoRepository;
                }
                return _UserInfoRepository;
            }
            set { _UserInfoRepository = value; }
        }
	}
}  