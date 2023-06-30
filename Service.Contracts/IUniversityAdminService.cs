using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IUniversityAdminService
{
    Task<IEnumerable<UserDto>> GetAllAdmins(Guid universityId, bool trackChanges);
    Task<UserDto> GetUniveristyAdmin(Guid universityId, Guid id, bool trackChanges);
    UniversityAdminDto GetUniveristyAdminById(Guid id, bool trackChanges);
    Task<UserDto> CreateAdminForUniversity(Guid universityId, UserForCreationDto admin, bool trackChanges);
    Task DeleteAdminForUniversity(Guid universityId, Guid id, bool trackChanges);
    Task UpdateAdminForUniversity(Guid universityId, Guid id, UserForUpdateDto admin, bool uniTrackChanges, bool admTrackChanges);
}