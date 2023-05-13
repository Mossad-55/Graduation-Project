using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasData
        (
            new Professor
            {
                Id = new Guid("706870e9-e373-11ed-b719-105badc84798"),
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                IFrame = ""
            },
            new Professor
            {
                Id = new Guid("706b3236-e373-11ed-a003-105badc84798"),
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                IFrame = ""
            },
            new Professor
            {
                Id = new Guid("706b3237-e373-11ed-988f-105badc84798"),
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                IFrame = ""
            }
        );
    }
}
