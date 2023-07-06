using act.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace act.Contexts
{
    internal class ProjectDbContext: DbContext
    {
        public ProjectDbContext(): base(ConfigurationManager.ConnectionStrings[1].ConnectionString)
        {
            Database.SetInitializer<ProjectDbContext>(new DropCreateDatabaseIfModelChanges<ProjectDbContext>());
        }
        public virtual DbSet<ProjectModel> Projects { get; set; }
        public virtual DbSet<RoleModel> Roles { get; set; }
    }
}
