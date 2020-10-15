using RepositoryDesignPattern.Configurations;
using RepositoryDesignPattern.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern
{
    public class Context : DbContext
    {
        public Context() : base("Server=(LocalDb)\\MSSQLLocalDB; Initial Catalog=RepositoryDesignPattern; Integrated Security=true")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>(true));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
        }
    }
}
