using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasData
        (
            new Faculty
            {
                Id = new Guid("D0552B49-6E7D-4CED-8A30-62CE8066A2D4"),
                Name = "Faculty Of Computer Science and Information Technology",
                Description = "We believe that software and information technology is the future, hence we have recruited our knowledge in the fields of information system and automation.",
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            },
            new Faculty
            {
                Id = new Guid("2694C80B-F092-4975-9688-5565CF1E67FC"),
                Name = "Faculty Of Science",
                Description = "The Faculty of Science at Damanhour University is a renowned academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of science, preparing them for successful careers in research, academia, and industry.",
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            },
            new Faculty
            {
                Id = new Guid("0F3B208B-2006-4C07-878F-27E4DD1CC99E"),
                Name = "Faculty Of Engineering",
                Description = "The Faculty of Engineering at Damanhour University is a prestigious academic institution located in the city of Damanhour, Egypt. The faculty is dedicated to providing students with a comprehensive education in the field of engineering, preparing them for successful careers in research, academia, and industry.",
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            },
            new Faculty
            {
                Id = new Guid("FAFBC1D0-D161-4F1E-9EF6-F7CFD23D97F5"),
                Name = "Faculty Of Commerce",
                Description = "The Faculty of Commerce at Damanhour University is a leading academic institution located in the city of Damanhour, Egypt. The faculty is committed to providing high-quality education and training to students in the field of commerce and business.",
                UniversityId = new Guid("86f697d4-a762-44d6-8322-2c08c66f94e4")
            }
        );
    }
}
