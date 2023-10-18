using LeaveManagementWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWebApp.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e",
                    Email = "Admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "Admin@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed= true
                },
                new Employee
                {
                    Id = "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e",
                    Email = "User@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName= "User@localhost.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2"),
                    EmailConfirmed = true
                });
        }
    }
}