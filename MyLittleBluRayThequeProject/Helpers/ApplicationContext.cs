using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBluRayThequeProject.Helpers
{
    public class ApplicationContext : IDisposable, IApplicationContext

    {
        private bool disposed;
        private readonly DatabaseContext databaseContext;

        public ApplicationContext(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
            disposed = false;
        }

        public DatabaseContext GetDatabaseContext()
        {
            return databaseContext;
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return GetDatabaseContext().Set<T>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }

            disposed = true;
        }
    }
}
