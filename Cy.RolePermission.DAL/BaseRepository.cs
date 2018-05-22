using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Cy.RolePermission.DAL
{
    public class BaseRepository<T> where T : class, new()
    {
        public DbContext DbContext { get { return DbContextFactroy.GetCurrentDbContext(); } }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambad"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllEntity(Expression<Func<T, bool>> whereLambad)
        {
            return DbContext.Set<T>().Where(whereLambad);
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="entity">需要包含的实体</param>
        /// <returns></returns>
        public IQueryable<T> GetAllEntity(string entity)
        {
            return string.IsNullOrEmpty(entity) ? DbContext.Set<T>().AsQueryable() : DbContext.Set<T>().Include(entity).AsQueryable();
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="S">实体对象</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">当前</param>
        /// <param name="totalCount">总记录数</param>
        /// <param name="whereLambda">条件表达式</param>
        /// <param name="orderbyLambda">排序条件</param>
        /// <param name="isAsc">是否升序(true:升序,false:降序)</param>
        /// <returns></returns>
        public IQueryable<T> GetPageEntity<S>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, bool? isAsc)
        {
            var entity = DbContext.Set<T>().Where(whereLambda);
            totalCount = entity.Count();
            if (isAsc.HasValue)
            {
                entity = isAsc.Value ? entity.OrderBy(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize) : entity.OrderByDescending(orderbyLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                entity = entity.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            return entity;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">添加的实体</param>
        /// <returns></returns>
        public T Insert(T entity)
        {
            DbContext.Set<T>().Add(entity);
            return entity;
        }
        
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            return true;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public bool Delete(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Deleted;
            return true;
        }
    }
}
