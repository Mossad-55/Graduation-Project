namespace Shared.DataTranferObjects;

public record SubjectForProfessorDto
{
    public Guid Id { get; init; }
    public string? FullName { get; init; }
    public double Rate { get; init; }

    public ICollection<QuestionnaireForSubjectDto>? Questionnaires { get; set; }
}
