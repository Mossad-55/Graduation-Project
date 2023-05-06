namespace Shared.DataTranferObjects;

public record SubjectDetailsForStudentDto
{
    public Guid Id { get; init; }
    public string? FullName { get; init; }
    public double Rate { get; init; }
}
