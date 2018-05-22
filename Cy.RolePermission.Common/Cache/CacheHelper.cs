using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.Common.Cache
{
    public class CacheHelper
    {
        private static ICacheWhite CacheWhite { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        public static void AddCache(string key, object obj)
        {
            CacheWhite.AddCache(key, obj);
        }

        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        /// <param name="expires">过期时间</param>
        public static void AddCache(string key, object obj, DateTime expires)
        {
            CacheWhite.AddCache(key, obj, expires);
        }

        /// <summary>
        /// 修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        public static void EditCache(string key, object obj)
        {
            CacheWhite.EditCache(key, obj);
        }

        /// <summary>
        /// 修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        /// <param name="expires">过期时间</param>
        public static void EditCache(string key, object obj, DateTime expires)
        {
            CacheWhite.EditCache(key, obj, expires);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static object GetCache(string key)
        {
            return CacheWhite.GetCache(key);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static T GetCache<T>(string key)
        {
            return (T)CacheWhite.GetCache<T>(key);
        }

        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key">键</param>
        public static void RemoveCache(string key)
        {
             CacheWhite.RemoveCache(key);
        }
    }
}
