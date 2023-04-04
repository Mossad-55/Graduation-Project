using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData
        (
            new IdentityRole
            {
                Name = "University Admin",
                NormalizedName = "UNIVERSITY ADMIN"
            },
            new IdentityRole
            {
                Name = "Faculty Admin",
                NormalizedName = "FACULTY ADMIN"
            },
            new IdentityRole
            {
                Name = "Department Admin",
                NormalizedName = "DEPARTMENT ADMIN"
            },
            new IdentityRole
            {
                Name = "Professor",
                NormalizedName = "PROFESSOR"
            },
            new IdentityRole
            {
                Name = "Student",
                NormalizedName = "STUDENT"
            }
        );
    }
}
