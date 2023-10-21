using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagementWebApp.Constants;

namespace LeaveManagementWebApp.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                    new IdentityRole
                    {
                        Id = "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e",
                        Name = Roles.User,
                        NormalizedName = Roles.User.ToUpper()
                    }
                );
        }
    }
}