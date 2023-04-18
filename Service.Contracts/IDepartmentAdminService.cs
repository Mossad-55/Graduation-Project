using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IDepartmentAdminService
{
    Task<IEnumerable<AdminDto>> GetAllAdmins(Guid facultyId, Guid departmentId, bool trackChanges);
    Task<AdminDto> GetDepartmentAdmin(Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    Task<AdminDto> CreateAdminForDepartment(Guid universityId, Guid facultyId, Guid departmentId, AdminForCreationDto admin, bool trackChanges);
    Task DeleteAdminForDepartment(Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    Task UpdateAdminForDepartment(Guid facultyId, Guid departmentId, Guid id, AdminForUpdateDto admin, bool othTrackChanges, bool admTrackChanges);
}
