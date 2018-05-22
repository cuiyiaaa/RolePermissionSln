using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IDAL
{
    public interface IBaseRepository<T> where T:class,new ()
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambad"></param>
        /// <returns></returns>
       IQueryable<T> GetAllEntity(Expression<Func<T, bool>> whereLambad);

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="entity">需要包含的实体</param>
        /// <returns></returns>
       IQueryable<T> GetAllEntity(string entity);

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
        IQueryable<T> GetPageEntity<S>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, bool? isAsc);
        
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">添加的实体</param>
        /// <returns></returns>
        T Insert(T entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        bool Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        bool Delete(T entity);
    }
}
