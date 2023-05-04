﻿using Entities.Models;
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
                RoleId = "A2523A70-57E3-4B69-A405-F9752517ED62"
            },
            new IdentityUserRole<string>
            {
                UserId = "7A369173-1E2F-491F-874F-7B324C034BC2",
                RoleId = "64F2143D-B896-4355-90D2-AFD22424B234"
            },
            new IdentityUserRole<string>
            {
                UserId = "FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2",
                RoleId = "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7"
            },
            new IdentityUserRole<string>
            {
                UserId = "706870e9-e373-11ed-b719-105badc84798",
                RoleId = "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7"
            },
            new IdentityUserRole<string>
            {
                UserId = "706b3236-e373-11ed-a003-105badc84798",
                RoleId = "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7"
            },
            new IdentityUserRole<string>
            {
                UserId = "706b3237-e373-11ed-988f-105badc84798",
                RoleId = "E5E3E33B-D9F2-4E95-9CEB-26F28A0028E7"
            },
            new IdentityUserRole<string>
            {
                UserId = "5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4A8CA884-C093-43C4-A019-EE6D804BF85E",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            }
        );
    }
}
