using Microsoft.EntityFrameworkCore;
using MyLittleBluRayThequeProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBluRayThequeProject.Helpers
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<BluRay> BluRay {  get; set; }

        public DbSet<Personne> Personne { get; set; }

    }
}
