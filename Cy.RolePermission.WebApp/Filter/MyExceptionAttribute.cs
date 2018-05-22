using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cy.RolePermission.WebApp.Filter
{
    public class MyExceptionAttribute : HandleErrorAttribute
    {
        #region Redis队列
        //public static IRedisClientsManager ClientsManager = new PooledRedisClientManager(new string[] { "127.0.0.1:6379" });
        //public static IRedisClient redisClient = ClientsManager.GetClient(); 
        #endregion

        public override void OnException(ExceptionContext filterContext)
        {

            #region Redis
            //组织异常消息
            //string strError = string.Format("消息类型：{0}<br>消息内容：{1}<br>引发异常的方法：{2}<br>引发异常的对象：{3}<br>异常目录：{4}<br>异常文件：{5}", filterContext.Exception.GetType().Name, filterContext.Exception.Message, filterContext.Exception.TargetSite, filterContext.Exception.Source, filterContext.RouteData.GetRequiredString("controller"), filterContext.RouteData.GetRequiredString("action"));
            ////添加到Redis队列中
            //redisClient.EnqueueItemOnList("Error_Msg", strError); 
            #endregion
            Common.Log.LogHelper.LogWhite(filterContext.Exception);
            filterContext.HttpContext.Response.Redirect("/ErrorHtml/Error404.html");
            //filterContext.Result = new RedirectResult("/ErrorHtml/Error404.html");
            base.OnException(filterContext);
        }
    }
}