using Cy.RolePermission.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IBLL
{
    public interface IBaseService<T> where T : class, new()
    {
        IDbSession DbSession { get;}
        IBaseRepository<T> CurrentRepository { get; set; }
        IQueryable<T> GetAllEntity(Expression<Func<T, bool>> whereLambad);
        IQueryable<T> GetAllEntity(string entity);
        IQueryable<T> GetPageEntity<S>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderbyLambda, bool? isAsc);
        T Add(T entity);
        bool Edit(T entity);
        bool Remove(T entity);
    }
}
