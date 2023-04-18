using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IFacultyAdminService
{
    Task<IEnumerable<AdminDto>> GetAllAdmins(Guid universityId, Guid facultyId, bool trackChanges);
    Task<AdminDto> GetFacultyAdmin(Guid universityId, Guid facultyId, Guid id, bool trackChanges);
    Task<AdminDto> CreateAdminForFaculty(Guid universityId, Guid facultyId, AdminForCreationDto admin, bool trackChanges);
    Task DeleteAdminForFaculty(Guid universityId, Guid facultyId, Guid id, bool trackChanges);
    Task UpdateAdminForFaculty(Guid universityId, Guid facultyId, Guid id, AdminForUpdateDto admin, bool trackChanges);
}
