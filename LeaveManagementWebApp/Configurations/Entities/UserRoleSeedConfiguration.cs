using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWebApp.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ca57afe6-4182-4d62-8d86-f9f0a9eebe6e",
                    UserId= "ba57afe6-4183-4d62-8dc6-f9f0a8eebe8e"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "ba57afe7-4183-4d63-8dc7-f9f0a9eebe8e",
                     UserId = "ca57afe6-4183-4e62-8dc6-f9f0a8eebe8e"
                 });
        }
    }
}