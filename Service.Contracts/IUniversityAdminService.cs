using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IUniversityAdminService
{
    Task<IEnumerable<UniversityAdminDto>> GetAllAdmins(Guid universityId, bool trackChanges);
    Task<UniversityAdminDto> GetUniveristyAdmin(Guid universityId, Guid id, bool trackChanges);
    Task<UniversityAdminDto> CreateAdminForUniversity(Guid universityId, UniversityAdminForCreationDto admin, bool trackChanges);
    Task DeleteAdminForUniversity(Guid universityId, Guid id, bool trackChanges);
    Task UpdateAdminForUniversity(Guid universityId, Guid id, UniversityAdminForUpdateDto admin, bool uniTrackChanges, bool admTrackChanges);
}