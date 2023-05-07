using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class SubmitionConfiguration : IEntityTypeConfiguration<Submition>
{
    public void Configure(EntityTypeBuilder<Submition> builder)
    {
        builder.HasData
        (
            new Submition
            {
                Id = Guid.NewGuid(),
                AssisTeacher = 2,
                CourseMarket = 3,
                CourseRecommend = 4,
                CourseUnderstand = 5,
                ExamContent = 5,
                InstEffic = 5,
                InstMaterial = 6,
                InstRecommend = 6,
                IntRespect = 7,
                QuestionnaireId = new Guid(""),
                StudentId = new Guid(""),
                SubmitionDate = new DateTime(2022, 3, 4)
            }
        );
    }
}
