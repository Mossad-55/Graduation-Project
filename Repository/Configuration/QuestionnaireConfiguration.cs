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
                Id = new Guid("9837ead0-e3a8-11ed-8e26-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811c3-e3a8-11ed-89a2-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811c4-e3a8-11ed-acb0-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811c5-e3a8-11ed-b7b4-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811c6-e3a8-11ed-91f0-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811c7-e3a8-11ed-b616-105badc84798"),
                Title = "Week 1 Questionnaire",
                CreatedAt = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            },
            new Questionnaire
            {
                Id = new Guid("983811c8-e3a8-11ed-9abf-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811c9-e3a8-11ed-a426-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811ca-e3a8-11ed-8af8-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811cb-e3a8-11ed-a105-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811cc-e3a8-11ed-8898-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811cd-e3a8-11ed-aee4-105badc84798"),
                Title = "Week 2 Questionnaire",
                CreatedAt = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            },
            new Questionnaire
            {
                Id = new Guid("983811ce-e3a8-11ed-b7fa-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811cf-e3a8-11ed-9142-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811d0-e3a8-11ed-be64-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811d1-e3a8-11ed-95d3-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811d2-e3a8-11ed-a075-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811d3-e3a8-11ed-992a-105badc84798"),
                Title = "Week 3 Questionnaire",
                CreatedAt = new DateTime(2023, 3, 1),
                EndDate = new DateTime(2023, 3, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            },
            new Questionnaire
            {
                Id = new Guid("983811d4-e3a8-11ed-adf9-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811d5-e3a8-11ed-9f52-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811d6-e3a8-11ed-8e5e-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811d7-e3a8-11ed-9e89-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811d8-e3a8-11ed-807d-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811d9-e3a8-11ed-86bc-105badc84798"),
                Title = "Week 4 Questionnaire",
                CreatedAt = new DateTime(2023, 4, 1),
                EndDate = new DateTime(2023, 4, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            },
            new Questionnaire
            {
                Id = new Guid("983811da-e3a8-11ed-a5a1-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811db-e3a8-11ed-900a-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811dc-e3a8-11ed-b3b5-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811dd-e3a8-11ed-a035-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811de-e3a8-11ed-8647-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811df-e3a8-11ed-a293-105badc84798"),
                Title = "Week 5 Questionnaire",
                CreatedAt = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            },
            new Questionnaire
            {
                Id = new Guid("983811e0-e3a8-11ed-a285-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("40504BB7-1148-4E05-BA84-2A81FFC3B918")
            },
            new Questionnaire
            {
                Id = new Guid("983811e1-e3a8-11ed-af0c-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("5FECD989-AF05-4E8F-80A3-EBDA42971BB3")
            },
            new Questionnaire
            {
                Id = new Guid("983811e2-e3a8-11ed-a048-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("15EE4163-B1D7-4FFD-9357-AE82B0CBA7A0")
            },
            new Questionnaire
            {
                Id = new Guid("983811e3-e3a8-11ed-95be-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("17105397-5AA7-452E-BBB5-26A690C56553")
            },
            new Questionnaire
            {
                Id = new Guid("983811e4-e3a8-11ed-83ea-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("F9D69186-526F-4141-92E0-8D8B29EE347F")
            },
            new Questionnaire
            {
                Id = new Guid("983811e5-e3a8-11ed-89f7-105badc84798"),
                Title = "Week 6 Questionnaire",
                CreatedAt = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 6, 15),
                SubjectId = new Guid("1F80D7C4-3DD1-4365-9420-558E223F0EE6")
            }
        );
    }
}