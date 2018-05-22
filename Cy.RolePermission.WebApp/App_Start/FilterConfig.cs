using Cy.RolePermission.WebApp.Filter;
using System.Web;
using System.Web.Mvc;

namespace Cy.RolePermission.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MyExceptionAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
