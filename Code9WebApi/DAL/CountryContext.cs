using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Code9WebApi.Models;

namespace Code9WebApi.DAL
{
    public class CountryContext : DbContext
    {
        public CountryContext() : base("CountryContext")
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}