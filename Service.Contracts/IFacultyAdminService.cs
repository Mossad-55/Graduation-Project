using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IFacultyAdminService
{
    Task<IEnumerable<UserDto>> GetAllAdmins(Guid facultyId, bool trackChanges);
    Task<UserDto> GetFacultyAdmin(Guid facultyId, Guid id, bool trackChanges);
    FacultyAdminDto GetFacultyAdminById(Guid id, bool trackChanges);
    Task<UserDto> CreateAdminForFaculty(Guid facultyId, UserForCreationDto admin, bool trackChanges);
    Task DeleteAdminForFaculty(Guid facultyId, Guid id, bool trackChanges);
    Task UpdateAdminForFaculty(Guid facultyId, Guid id, UserForUpdateDto admin, bool trackChanges);
}
