using Cy.RolePermission.WebApp.Filter;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cy.RolePermission.WebApp
{
    public class MvcApplication : Spring.Web.Mvc.SpringMvcApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //加载Log4Net配置文件
            log4net.Config.XmlConfigurator.Configure();
            //RecordLog();
        }

        #region 使用Redis队列
        /// <summary>
        /// 使用Redis队列
        /// </summary>
        //void RecordLog()
        //{
        //    ThreadPool.QueueUserWorkItem(o =>
        //      {
        //          while (true)
        //          {

        //              if (MyExceptionAttribute.redisClient.GetListCount("Error_Msg") > 0)
        //              {
        //                  string str = MyExceptionAttribute.redisClient.DequeueItemFromList("Error_Msg");
        //                  log4net.ILog log = log4net.LogManager.GetLogger("admin");
        //                  log.Error(str);
        //              }
        //              else
        //              {
        //                  Thread.Sleep(3000);
        //              }
        //          }
        //      });
        //} 
        #endregion
    }
}
