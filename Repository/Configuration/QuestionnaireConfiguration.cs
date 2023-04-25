using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class QuestionnaireConfiguration : IEntityTypeConfiguration<Questionnaire>
{
    public void Configure(EntityTypeBuilder<Questionnaire> builder)
    {
        builder.HasData
        (
            new Questionnaire
            {
                Id = new Guid("7CE1835E-B1E6-4EA2-8F77-5DD0406450A2"),
                Title = "Week 1 Questionnaire",
                CreatedAt = DateTime.Now,
                EndDate = DateTime.Now.AddDays(6),
                SubjectId = new Guid("")
            }
        );
    }
}
