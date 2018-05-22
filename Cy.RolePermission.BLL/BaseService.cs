using Cy.RolePermission.DALFactory;
using Cy.RolePermission.IDAL;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cy.RolePermission.BLL
{
    public class BaseService<T> where T : class, new()
    {
        public IDbSession DbSession { get { return DbSessionFactory.GetCurrentDbSession(); } }
        public IBaseRepository<T> CurrentRepository { get; set; }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambad"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllEntity(Expression<Func<T, bool>> whereLambad)
        {
            return CurrentRepository.GetAllEntity(whereLambad);
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="entity">需要包含的实体</param>
        /// <returns></returns>
        public IQueryable<T> GetAllEntity(string entity)
        {
            return CurrentRepository.GetAllEntity(entity);
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
            return CurrentRepository.GetPageEntity(pageIndex, pageSize, out totalCount, whereLambda, orderbyLambda, isAsc);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">添加的实体</param>
        /// <returns></returns>
        public T Add(T entity)
        {
            CurrentRepository.Insert(entity);
            DbSession.SaveChanges();
            return entity;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public bool Edit(T entity)
        {
            CurrentRepository.Update(entity);
            return DbSession.SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public bool Remove(T entity)
        {
            CurrentRepository.Delete(entity);
            return DbSession.SaveChanges();
        }
    }
}
