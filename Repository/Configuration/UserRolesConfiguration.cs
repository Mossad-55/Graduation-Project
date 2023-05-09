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
            },
            new IdentityUserRole<string>
            {
                UserId = "4093fa25-ed6b-11ed-a6df-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4093fa27-ed6b-11ed-8922-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4093fa29-ed6b-11ed-85ba-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4093fa2b-ed6b-11ed-9be9-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4093fa2d-ed6b-11ed-a65f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676b0-ed6b-11ed-9fd6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676b2-ed6b-11ed-b62e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676b4-ed6b-11ed-b886-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676b6-ed6b-11ed-b477-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676b8-ed6b-11ed-9c16-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676ba-ed6b-11ed-adbf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676bc-ed6b-11ed-9b21-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676be-ed6b-11ed-902b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676c0-ed6b-11ed-a990-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676c2-ed6b-11ed-a696-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409676c4-ed6b-11ed-a637-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "40977647-ed6b-11ed-aad8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "40977649-ed6b-11ed-973e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097764b-ed6b-11ed-b259-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097973c-ed6b-11ed-9913-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097973e-ed6b-11ed-929c-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "40979740-ed6b-11ed-8c11-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "40979742-ed6b-11ed-b3de-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "40979744-ed6b-11ed-8abc-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097c4fc-ed6b-11ed-84e8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097c4fe-ed6b-11ed-b56a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097c500-ed6b-11ed-b1ae-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8e5-ed6b-11ed-8a0f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8e7-ed6b-11ed-b377-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8e9-ed6b-11ed-83d1-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8eb-ed6b-11ed-8f98-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8ed-ed6b-11ed-9f99-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8ef-ed6b-11ed-8cd4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8f1-ed6b-11ed-aa86-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8f3-ed6b-11ed-9479-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8f5-ed6b-11ed-aca2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8f7-ed6b-11ed-98e4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8f9-ed6b-11ed-8f23-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8fb-ed6b-11ed-b285-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8fd-ed6b-11ed-b6a3-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d8ff-ed6b-11ed-85f9-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d901-ed6b-11ed-9297-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d903-ed6b-11ed-855f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d905-ed6b-11ed-b302-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d907-ed6b-11ed-b6b6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d909-ed6b-11ed-93d8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d90b-ed6b-11ed-a99b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d90d-ed6b-11ed-956f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d90f-ed6b-11ed-a0cc-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d911-ed6b-11ed-b614-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d913-ed6b-11ed-816e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4097d915-ed6b-11ed-a890-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b15b-ed6b-11ed-9dc2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b15d-ed6b-11ed-8903-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b15f-ed6b-11ed-a7e2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b161-ed6b-11ed-b0d0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b163-ed6b-11ed-b901-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b165-ed6b-11ed-a2fd-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b167-ed6b-11ed-9dcf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b169-ed6b-11ed-9b69-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b16b-ed6b-11ed-bc54-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b16d-ed6b-11ed-abd9-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b16f-ed6b-11ed-ae81-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b171-ed6b-11ed-bd08-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b173-ed6b-11ed-9e0c-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b175-ed6b-11ed-a3d4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b177-ed6b-11ed-b8db-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b179-ed6b-11ed-acd6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b17b-ed6b-11ed-bfb2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b17d-ed6b-11ed-a36b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b17f-ed6b-11ed-9639-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b181-ed6b-11ed-84ef-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b183-ed6b-11ed-91ba-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b185-ed6b-11ed-a00a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b187-ed6b-11ed-911e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b189-ed6b-11ed-97ff-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b18b-ed6b-11ed-9c96-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b18d-ed6b-11ed-86a0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b18f-ed6b-11ed-9b38-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b191-ed6b-11ed-87ba-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b193-ed6b-11ed-b6af-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b195-ed6b-11ed-a317-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b197-ed6b-11ed-a380-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b199-ed6b-11ed-bf11-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b19b-ed6b-11ed-9acc-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b19d-ed6b-11ed-9edb-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b19f-ed6b-11ed-8419-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b1a1-ed6b-11ed-abac-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b1a3-ed6b-11ed-a583-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b1a5-ed6b-11ed-bf0d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4098b1a7-ed6b-11ed-bd68-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9d3-ed6b-11ed-b4e8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9d5-ed6b-11ed-8061-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9d7-ed6b-11ed-976d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9d9-ed6b-11ed-bca8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9db-ed6b-11ed-9009-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9dd-ed6b-11ed-8e81-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9df-ed6b-11ed-bb40-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9e1-ed6b-11ed-b492-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9e3-ed6b-11ed-92d1-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9e5-ed6b-11ed-b38a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9e7-ed6b-11ed-9432-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9e9-ed6b-11ed-af1e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9eb-ed6b-11ed-8d45-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9ed-ed6b-11ed-8755-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9ef-ed6b-11ed-a4a1-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9f1-ed6b-11ed-b017-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9f3-ed6b-11ed-92c8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9f5-ed6b-11ed-9bbb-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9f7-ed6b-11ed-aa9d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9f9-ed6b-11ed-8af4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9fb-ed6b-11ed-88c6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9fd-ed6b-11ed-a891-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099e9ff-ed6b-11ed-a802-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea01-ed6b-11ed-a7d5-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea03-ed6b-11ed-9ac8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea05-ed6b-11ed-b96b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea07-ed6b-11ed-9c9b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea09-ed6b-11ed-9690-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea0b-ed6b-11ed-b0ef-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea0d-ed6b-11ed-aa2b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea0f-ed6b-11ed-9d4e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea11-ed6b-11ed-8a4f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea13-ed6b-11ed-839a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea15-ed6b-11ed-8dbe-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea17-ed6b-11ed-bb52-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea19-ed6b-11ed-85c8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea1b-ed6b-11ed-b4c0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea1d-ed6b-11ed-a4c6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "4099ea1f-ed6b-11ed-9f62-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2251-ed6b-11ed-9a82-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2253-ed6b-11ed-b650-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2255-ed6b-11ed-87ce-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2257-ed6b-11ed-8f44-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2259-ed6b-11ed-ac78-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b225b-ed6b-11ed-bf67-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b225d-ed6b-11ed-8369-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b225f-ed6b-11ed-8d6a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2261-ed6b-11ed-b7f8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2263-ed6b-11ed-93b0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2265-ed6b-11ed-8a51-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2267-ed6b-11ed-9ed8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2269-ed6b-11ed-96a1-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b226b-ed6b-11ed-b5d0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b226d-ed6b-11ed-9578-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b226f-ed6b-11ed-af75-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2271-ed6b-11ed-b13a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2273-ed6b-11ed-984c-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2275-ed6b-11ed-8ea0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2277-ed6b-11ed-a519-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2279-ed6b-11ed-a66d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b227b-ed6b-11ed-a6a6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b227d-ed6b-11ed-b8fd-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b227f-ed6b-11ed-9609-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2281-ed6b-11ed-968e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2283-ed6b-11ed-90f7-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2285-ed6b-11ed-945d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2287-ed6b-11ed-bdd8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2289-ed6b-11ed-8a33-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b228b-ed6b-11ed-82cb-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b228d-ed6b-11ed-9862-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b228f-ed6b-11ed-bba0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2291-ed6b-11ed-82b0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2293-ed6b-11ed-a281-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2295-ed6b-11ed-a03f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2297-ed6b-11ed-9620-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b2299-ed6b-11ed-8cd7-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409b229b-ed6b-11ed-b5e4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5ba9-ed6b-11ed-a9f0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bab-ed6b-11ed-9ebb-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bad-ed6b-11ed-b06e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5baf-ed6b-11ed-b43f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bb1-ed6b-11ed-b22e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bb3-ed6b-11ed-8aea-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bb5-ed6b-11ed-81ec-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bb7-ed6b-11ed-a54a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bb9-ed6b-11ed-a374-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bbb-ed6b-11ed-a145-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bbd-ed6b-11ed-a7f3-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bbf-ed6b-11ed-afcf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bc1-ed6b-11ed-880d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bc3-ed6b-11ed-b2b0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bc5-ed6b-11ed-9c33-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bc7-ed6b-11ed-a584-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bc9-ed6b-11ed-94df-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bcb-ed6b-11ed-ae48-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bcd-ed6b-11ed-82bc-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bcf-ed6b-11ed-a53b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bd1-ed6b-11ed-8709-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bd3-ed6b-11ed-b60d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bd5-ed6b-11ed-92ef-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bd7-ed6b-11ed-8e67-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bd9-ed6b-11ed-aac6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bdb-ed6b-11ed-9c54-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bdd-ed6b-11ed-9d5b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bdf-ed6b-11ed-8964-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5be1-ed6b-11ed-858f-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5be3-ed6b-11ed-a6f1-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5be5-ed6b-11ed-b9bc-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5be7-ed6b-11ed-a4c2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5be9-ed6b-11ed-84f0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5beb-ed6b-11ed-9119-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bed-ed6b-11ed-b13d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bef-ed6b-11ed-a904-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bf1-ed6b-11ed-88f4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bf3-ed6b-11ed-b6f9-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409c5bf5-ed6b-11ed-b0e0-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97e6-ed6b-11ed-8b4d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97e8-ed6b-11ed-94e7-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97ea-ed6b-11ed-8bcf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97ec-ed6b-11ed-b463-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97ee-ed6b-11ed-bbdf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97f0-ed6b-11ed-90bb-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97f2-ed6b-11ed-a6cf-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97f4-ed6b-11ed-bb0c-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97f6-ed6b-11ed-a3b6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97f8-ed6b-11ed-9814-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97fa-ed6b-11ed-962d-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97fc-ed6b-11ed-aad6-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d97fe-ed6b-11ed-9246-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9800-ed6b-11ed-a52b-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9802-ed6b-11ed-bc09-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9804-ed6b-11ed-acac-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9806-ed6b-11ed-bd30-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9808-ed6b-11ed-ad60-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d980a-ed6b-11ed-8f53-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d980c-ed6b-11ed-ab6a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d980e-ed6b-11ed-a002-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9810-ed6b-11ed-8ef2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9812-ed6b-11ed-9c48-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9814-ed6b-11ed-b1a5-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9816-ed6b-11ed-a024-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9818-ed6b-11ed-a744-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d981a-ed6b-11ed-8cc2-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d981c-ed6b-11ed-a136-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d981e-ed6b-11ed-b364-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9820-ed6b-11ed-b8a4-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9822-ed6b-11ed-b007-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9824-ed6b-11ed-b245-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9826-ed6b-11ed-903e-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9828-ed6b-11ed-8629-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d982a-ed6b-11ed-b3f7-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d982c-ed6b-11ed-9084-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d982e-ed6b-11ed-8e42-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9830-ed6b-11ed-abc8-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9832-ed6b-11ed-8176-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9834-ed6b-11ed-883a-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9836-ed6b-11ed-8979-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d9838-ed6b-11ed-ac79-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            },
            new IdentityUserRole<string>
            {
                UserId = "409d983a-ed6b-11ed-890c-105badc84798",
                RoleId = "E26639C4-7023-4878-A497-FC4B12CFA272"
            }
        );
    }
}
