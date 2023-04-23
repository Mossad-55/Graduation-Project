using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IDepartmentAdminService
{
    Task<IEnumerable<UserDto>> GetAllAdmins(Guid departmentId, bool trackChanges);
    Task<UserDto> GetDepartmentAdmin(Guid departmentId, Guid id, bool trackChanges);
    Task<UserDto> CreateAdminForDepartment(Guid departmentId, UserForCreationDto admin, bool trackChanges);
    Task DeleteAdminForDepartment(Guid departmentId, Guid id, bool trackChanges);
    Task UpdateAdminForDepartment(Guid departmentId, Guid id, UserForUpdateDto admin, bool trackChanges);
}
