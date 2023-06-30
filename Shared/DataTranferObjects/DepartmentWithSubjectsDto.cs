namespace Shared.DataTranferObjects;

public record DepartmentWithSubjectsDto
{
    public string Name { get; init; }
    public double Rate { get; set; }
    public IEnumerable<SubjectForDepartmentDto> Subjects { get; init; }
}
