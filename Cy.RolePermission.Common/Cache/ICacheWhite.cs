using System;

namespace Cy.RolePermission.Common.Cache
{
    public interface ICacheWhite
    {
        void AddCache(string key, object obj);
        void AddCache(string key, object obj, DateTime expires);
        void RemoveCache(string key);
        object GetCache(string key);
        T GetCache<T>(string key);
        void EditCache(string key, object obj);
        void EditCache(string key, object obj, DateTime expires);
    }
}
