using ElifTech.Companies.Web.Context;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ElifTech.Companies.Web.DAL
{
    public class CompaniesContext:DbContext
    {
        public CompaniesContext():base("CompaniesContext")
        {

        }

        public DbSet<Companie> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}