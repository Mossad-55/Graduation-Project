using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData
        (
            new IdentityUserRole<string>
            {
                UserId = "99328045-8ECF-40A1-9F0B-0DEA6398F09A",
                RoleId = "BEA713C7-93D2-4F39-8DC8-18F2F3070779"
            },
            new IdentityUserRole<string>
            {
                UserId = "69E0E900-6DE2-45E8-85CA-583B32C5C5AA",
                RoleId = "BEA713C7-93D2-4F39-8DC8-18F2F3070779"
            }

        );
    }
}
