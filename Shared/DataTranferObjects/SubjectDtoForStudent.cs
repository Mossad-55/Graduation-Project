namespace Shared.DataTranferObjects;

public record SubjectDtoForStudent
{
    public Guid Id { get; init; }
    public string? FullName { get; init; }
    public QuestionnaireForSubjectDto? Questionnaire { get; set; }
}
