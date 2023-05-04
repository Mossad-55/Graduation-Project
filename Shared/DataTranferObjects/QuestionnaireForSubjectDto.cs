namespace Shared.DataTranferObjects;

public record QuestionnaireForSubjectDto
{
    public Guid Id { get; init; }
    public string? Title { get; init; }
    public int DurationInDays { get; init; }
    public bool IsActive { get; init; }
}
