namespace Shared.DataTranferObjects;

public class StudentDto
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; } 
    public ICollection<SubjectDto>? Subjects { get; set; }
}
