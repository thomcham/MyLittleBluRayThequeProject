using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBluRayThequeProject.Helpers
{
    public interface IApplicationContext
    {
        DatabaseContext GetDatabaseContext();
        DbSet<T> GetDbSet<T>() where T : class;
    }
}
