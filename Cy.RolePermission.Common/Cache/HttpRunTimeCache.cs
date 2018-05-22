using System;
using System.Web;

namespace Cy.RolePermission.Common.Cache
{
    public class HttpRunTimeCache : ICacheWhite
    {
        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        public void AddCache(string key, object obj)
        {
            HttpRuntime.Cache.Insert(key, obj);
        }

        /// <summary>
        /// 修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        /// <param name="expires">过期时间</param>
        public void AddCache(string key, object obj, DateTime expires)
        {
            HttpRuntime.Cache.Insert(key, obj, null, expires, TimeSpan.Zero);
        }

        /// <summary>
        /// 修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        public void EditCache(string key, object obj)
        {
            RemoveCache(key);
            AddCache(key, obj);
        }

        /// <summary>
        ///修改缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="obj">值</param>
        /// <param name="expires">过期时间</param>
        public void EditCache(string key, object obj, DateTime expires)
        {
            RemoveCache(key);
            AddCache(key, obj,expires);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public object GetCache(string key)
        {
            return HttpRuntime.Cache.Get(key);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetCache<T>(string key)
        {
            return (T)HttpRuntime.Cache.Get(key);
        }

        public void RemoveCache(string key)
        {
            throw new NotImplementedException();
        }
    }
}
