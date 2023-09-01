using Microsoft.EntityFrameworkCore;

namespace MultTenant.Models
{
    public class MultiTenantContext : DbContext 
    {

        public MultiTenantContext(DbContextOptions<MultiTenantContext> options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tenants = new List<Tenant>()
            {
                new Tenant()
                {
                    Id = 1,
                    Name = "SVCC",
                    DomainName = "www.siliconvalley-codecamp.com",
                    Default = true
                },
                new Tenant()
                {
                    Id = 2,
                    Name = "CSSC",
                    DomainName = "codestarssummit.com",
                    Default = false
                },
                new Tenant()
                {
                    Id = 3,
                    Name = "ANGU",
                    DomainName = "angularu.com",
                    Default = false
                }
            };
            modelBuilder.Entity<Tenant>().HasData(tenants);
        }
    }
}
