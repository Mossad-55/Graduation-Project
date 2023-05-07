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
                AssistantTeacher = 2,
                CourseMarket = 3,
                CourseRecommendation = 4,
                CourseUnderstand = 5,
                ExamContent = 5,
                InstructorEfficiency = 5,
                InstructorMaterial = 6,
                InstructorRecommendation = 6,
                InstructorRespect = 7,
                QuestionnaireId = new Guid(""),
                StudentId = new Guid(""),
                SubmitionDate = new DateTime(2022, 3, 4)
            }
        );
    }
}
