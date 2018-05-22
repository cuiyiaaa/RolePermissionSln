using Cy.RolePermission.DAL;
using Cy.RolePermission.IDAL;
using System.Data.Entity;

namespace Cy.RolePermission.DALFactory
{
    public partial class DbSession : IDbSession
    {
        public DbContext DbContext { get { return DbContextFactroy.GetCurrentDbContext(); } }

        public bool SaveChanges()
        {
            //DbContext.Configuration.ValidateOnSaveEnabled = false;
            return DbContext.SaveChanges() > 0;
        }

        public int ExecuteSql(string sql, params System.Data.SqlClient.SqlParameter[] ps)
        {
            return DbContext.Database.ExecuteSqlCommand(sql, ps);
        }

        //public DbRawSqlQuery<T> ExcuteSelectQuery<T>(string sql, System.Data.SqlClient.SqlParameter[] ps)
        //{
        //    return DbContext.Database.SqlQuery<T>(sql, ps);
        //}
    }
}
