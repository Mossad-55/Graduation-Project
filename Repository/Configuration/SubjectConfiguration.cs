using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasData
        (
            new Subject
            {
                Id = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918"),
                Name = "Parallel Computing",
                Code = "CS311",
                Description = "Parallel computing is a subject that focuses on the design and implementation of computing systems that are capable of performing multiple tasks simultaneously. This subject is offered in Damanhour University's Faculty of Computer Science and Information Technology, specifically within the Computer Science Department.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                ProfessorId = new Guid("FDC74EF3-1E3D-4A13-9F19-4E381CE4C3D2")
            }
        );
    }
}


