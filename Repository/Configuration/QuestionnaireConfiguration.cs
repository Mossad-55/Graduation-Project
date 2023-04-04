using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class QuestionnaireConfiguration : IEntityTypeConfiguration<Questionnaire>
{
    public void Configure(EntityTypeBuilder<Questionnaire> builder)
    {
        throw new NotImplementedException();
    }
}
