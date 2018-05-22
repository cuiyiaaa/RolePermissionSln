using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cy.RolePermission.IDAL
{
    public interface IDbContext
    {
        DbContext GetCurrentDbContext();
    }
}
