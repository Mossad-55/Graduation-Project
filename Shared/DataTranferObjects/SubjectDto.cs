namespace Shared.DataTranferObjects;

public record SubjectDto
{
    public Guid Id { get; init; }
    public string? FullName { get; init; }
    public string? Description { get; init; }
    public double Rate { get; init; }
    public string IFrame { get; set; }
    public Guid ProfessorId { get; init; }
}