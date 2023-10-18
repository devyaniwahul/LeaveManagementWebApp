using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"

                },
                    new IdentityRole
                    {
                        Id = "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e",
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );
        }
    }
}