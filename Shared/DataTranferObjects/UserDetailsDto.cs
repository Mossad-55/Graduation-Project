namespace Shared.DataTranferObjects;

public record UserDetailsDto
{
    public string? UserId { get; set; }
    public Guid UniversityId { get; set; }
    public Guid FacultyId { get; set; }
    public Guid DepartmentId { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
    public string? Token { get; set; }
    public bool IsAuthenticated { get; set; }
}
