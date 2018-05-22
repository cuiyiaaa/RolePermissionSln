using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.DAL
{
    public class DbContextFactroy
    {
        public static DbContext GetCurrentDbContext()
        {
            DbContext dbContext = CallContext.GetData("dbContext") as DbContext;
            if (dbContext==null)
            {
                dbContext = new Model1Container();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
