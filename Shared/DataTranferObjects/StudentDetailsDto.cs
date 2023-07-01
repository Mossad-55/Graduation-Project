namespace Shared.DataTranferObjects;

public record StudentDetailsDto
{
    public Guid UniveristyId { get; set; }
    public Guid FacultyId { get; set; }
    public Guid DepartmentId { get; set; }
}
