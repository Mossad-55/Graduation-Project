using Entities.Models;

namespace Contracts;

public interface IUniversityAdminRepository
{
    IEnumerable<UniversityAdmin> GetAllUniversityAdmins(Guid universityId, bool trackChanges);
    UniversityAdmin GetUniversityAdmin(Guid universityId, Guid id, bool trackChanges);
    UniversityAdmin GetUniversityAdminById(Guid id, bool trackChanges);
    void CreateUniversityAdmin(Guid universityId, UniversityAdmin universityAdmin);
    void DeleteUniversityAdmin(UniversityAdmin universityAdmin);
}
