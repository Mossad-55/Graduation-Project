using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasData
        (
            new Department
            {
                Id = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Name = "Computer Science",
                Description = "The Computer Science Department at Damanhour University is a vibrant academic community dedicated to advancing knowledge and technology in the field of computer science. The department offers a range of undergraduate and graduate programs that provide students with a solid foundation in computer science theory and practical skills.",
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
            },
            new Department
            {
                Id = new Guid("794DA9EB-B65E-45BA-A9DD-CAA9A22C7D40"),
                Name = "Information Technology",
                Description = "The Information Technology (IT) Department at Damanhour University is a dynamic and innovative academic community dedicated to advancing the field of information technology through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a comprehensive understanding of the theory and practice of IT.",
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
            },
            new Department
            {
                Id = new Guid("72B983A8-6386-498D-A114-0E241E7EEAE0"),
                Name = "Information System",
                Description = "The Information Systems (IS) Department at Damanhour University is a forward-thinking and innovative academic community dedicated to advancing the field of information systems through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a comprehensive understanding of the theory and practice of information systems.",
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
            },
            new Department
            {
                Id = new Guid("C65F6C7F-32F7-4797-A85B-92C9BA20ECB1"),
                Name = "Multimedia",
                Description = "The Multimedia Department at Damanhour University is a dynamic and creative academic community dedicated to advancing the field of multimedia through teaching, research, and service. The department offers a range of undergraduate and graduate programs that provide students with a solid foundation in multimedia theory and practical skills.",
                FacultyId = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
            }
        );
    }
}
