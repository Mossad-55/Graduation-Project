using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class UniversityAdminConfiguration : IEntityTypeConfiguration<UniversityAdmin>
{
    public void Configure(EntityTypeBuilder<UniversityAdmin> builder)
    {
        builder.HasData
        (
            new UniversityAdmin
            {
                Id = new Guid("8c67d240-d00a-4262-a286-c1027d6d0f9b"),
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            }
        );
    }
}
