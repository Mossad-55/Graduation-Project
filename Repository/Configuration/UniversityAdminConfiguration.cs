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
                Id = new Guid("99328045-8ECF-40A1-9F0B-0DEA6398F09A"),
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            }
        );
    }
}
