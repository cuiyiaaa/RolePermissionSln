using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IDAL
{
    public partial interface IDbSession
    {
        bool SaveChanges();
        int ExecuteSql(string sql, params System.Data.SqlClient.SqlParameter[] ps);
    }
}
