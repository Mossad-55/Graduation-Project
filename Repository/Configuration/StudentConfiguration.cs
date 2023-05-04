using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasData
        (
            new Student
            {
                Id = new Guid("5AAFE5DF-CB75-4DFA-898A-9A1C4E9BB5A5"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A")
            },
            new Student
            {
                Id = new Guid("4A8CA884-C093-43C4-A019-EE6D804BF85E"),
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                UniveristyId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4"),
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A")
            }
        );
    }
}
