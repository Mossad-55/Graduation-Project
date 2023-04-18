using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class DepartmentAdminConfiguration : IEntityTypeConfiguration<DepartmentAdmin>
{
    public void Configure(EntityTypeBuilder<DepartmentAdmin> builder)
    {
        builder.HasData
        (
            new DepartmentAdmin
            {
                Id = new Guid(""),
                DepartmentId = new Guid(""),
                FacultyId = new Guid(""),
                UniveristyId = new Guid("")
            }
        );
    }
}
