using LeaveManagementWebApp.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWebApp.Models;

namespace LeaveManagementWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public class yourDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        //{
        //    private const string ConnectionString = "Server=(localdb)\\\\mssqllocaldb;Database=aspnet-LeaveManagementWebApp;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";

        //    public ApplicationDbContext CreateDbContext(string[] args)
        //    {
        //        var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //        optionBuilder.UseSqlServer(ConnectionString);

        //            return new ApplicationDbContext(optionBuilder.Options);

        //    }
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations
        {
            get; set;
        }
    }
}