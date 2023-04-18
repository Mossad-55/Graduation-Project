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
                Id = new Guid(""),
                FacultyId = new Guid(""),
                UniveristyId = new Guid(""),
            }
        );
    }
}
