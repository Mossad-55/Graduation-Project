namespace Shared.DataTranferObjects;

public record ProfessorDetailsDto
{
    public Guid UniveristyId { get; set; }
    public Guid FacultyId { get; set; }
    public Guid DepartmentId { get; set; }
}
