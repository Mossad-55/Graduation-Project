namespace Shared.DataTranferObjects;

public record UniversityAdminDto()
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
}
