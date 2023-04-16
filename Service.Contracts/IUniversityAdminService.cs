using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IUniversityAdminService
{
    Task<IEnumerable<AdminDto>> GetAllAdmins(Guid universityId, bool trackChanges);
    Task<AdminDto> GetUniveristyAdmin(Guid universityId, Guid id, bool trackChanges);
    Task<AdminDto> CreateAdminForUniversity(Guid universityId, AdminForCreationDto admin, bool trackChanges);
    Task DeleteAdminForUniversity(Guid universityId, Guid id, bool trackChanges);
    Task UpdateAdminForUniversity(Guid universityId, Guid id, AdminForUpdateDto admin, bool uniTrackChanges, bool admTrackChanges);
}