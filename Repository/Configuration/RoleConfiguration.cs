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
                Id = "BEA713C7-93D2-4F39-8DC8-18F2F3070779",
                Name = "University Admin",
                NormalizedName = "UNIVERSITY ADMIN"
            },
            new IdentityRole
            {
                Id = "A2523A70-57E3-4B69-A405-F9752517ED62",
                Name = "Faculty Admin",
                NormalizedName = "FACULTY ADMIN"
            },
            new IdentityRole
            {
                Id = "64F2143D-B896-4355-90D2-AFD22424B234",
                Name = "Department Admin",
                NormalizedName = "DEPARTMENT ADMIN"
            },
            new IdentityRole
            {
                Id = "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7",
                Name = "Professor",
                NormalizedName = "PROFESSOR"
            },
            new IdentityRole
            {
                Id = "E26639C4-7023-4878-A497-FC4B12CFA272",
                Name = "Student",
                NormalizedName = "STUDENT"
            }
        );
    }
}
