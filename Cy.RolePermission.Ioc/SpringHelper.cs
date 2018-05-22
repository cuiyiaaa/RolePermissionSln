using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.Ioc
{
    public class SpringHelper
    {
        /// <summary>
        /// Spring容器上下文
        /// </summary>
        private static IApplicationContext SpringContext
        {
            get { return ContextRegistry.GetContext(); }
        }

        /// <summary>
        /// 通过配置文件创建对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objName"></param>
        /// <returns></returns>
        public static T GetObject<T>(string objName) where T : class
        {
            return (T)SpringContext.GetObject(objName);
        }
    }
}
