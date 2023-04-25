using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class FacultyAdminConfiguration : IEntityTypeConfiguration<FacultyAdmin>
{
    public void Configure(EntityTypeBuilder<FacultyAdmin> builder)
    {
        builder.HasData
        (
            new FacultyAdmin
            {
                Id = new Guid("69E0E900-6DE2-45E8-85CA-583B32C5C5AA"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
            }
        );
    }
}
