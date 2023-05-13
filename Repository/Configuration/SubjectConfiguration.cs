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
                Rate = 0,
                IFrame = "",
                ProfessorId = new Guid("706870e9-e373-11ed-b719-105badc84798")
            },
            new Subject
            {
                Id = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3"),
                Name = "Introduction to Computer Security",
                Code = "CS211",
                Description = "Introduction to Computer Security is a subject offered by the Computer Science Department at Damanhour University's Faculty of Computer Science and Information Technology. The course provides an overview of the fundamental concepts and principles of computer security, including the protection of computer systems, networks, and data from unauthorized access, theft, damage, and other security threats.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Rate = 4,
                IFrame = "",
                ProfessorId = new Guid("706870e9-e373-11ed-b719-105badc84798")
            },
            new Subject
            {
                Id = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0"),
                Name = "Capstone Project II",
                Code = "CS381",
                Description = "Capstone Project II is a course offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an opportunity to apply the knowledge and skills they have acquired throughout their academic program to a real-world problem or project.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Rate = 2.5,
                IFrame = "",
                ProfessorId = new Guid("706870e9-e373-11ed-b719-105badc84798")
            },
            new Subject
            {
                Id = new Guid("17105397-5AA7-452E-BBB5-26A690C56553"),
                Name = "Intelligent Systems",
                Code = "CS361",
                Description = "Intelligent Systems is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the design, development, and application of intelligent systems, which are computer systems that can perceive and respond to their environment, learn from experience, and make decisions based on data analysis and reasoning.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Rate = 3.5,
                IFrame = "",
                ProfessorId = new Guid("706870e9-e373-11ed-b719-105badc84798")
            },
            new Subject
            {
                Id = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F"),
                Name = "Advanced Database",
                Code = "CS212",
                Description = "Advanced Database is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course is designed to provide students with an in-depth understanding of advanced concepts and techniques used in database management systems.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Rate = 3,
                IFrame = "",
                ProfessorId = new Guid("706b3236-e373-11ed-a003-105badc84798")
            },
            new Subject
            {
                Id = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6"),
                Name = "Computer Animation",
                Code = "CS352",
                Description = "Computer Animation is a subject offered in the Computer Science Department of Damanhour University's Faculty of Computer Science and Information Technology. This course focuses on the principles and techniques used in the creation and manipulation of digital animations using computer software.",
                DepartmentId = new Guid("84796C48-D538-4954-A98A-622DC5C9325A"),
                Rate = 4,
                IFrame = "",
                ProfessorId = new Guid("706b3237-e373-11ed-988f-105badc84798")
            }
        );
    }
}


