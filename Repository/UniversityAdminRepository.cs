using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class UniversityAdminRepository : RepositoryBase<UniversityAdmin>, IUniversityAdminRepository
{
    public UniversityAdminRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateUniversityAdmin(Guid universityId, UniversityAdmin universityAdmin)
    {
        universityAdmin.UniversityId = universityId;
        Create(universityAdmin);
    }

    public void DeleteUniversityAdmin(UniversityAdmin universityAdmin) => Delete(universityAdmin);

    public IEnumerable<UniversityAdmin> GetAllUniversityAdmins(Guid universityId, bool trackChanges) =>
        FindByCondition(a => a.UniversityId == universityId, trackChanges)
        .OrderBy(a => a.FullName)
        .ToList();

    public UniversityAdmin GetUniversityAdmin(Guid universityId, Guid id, bool trackChanges) =>
        FindByCondition(a => a.UniversityId == universityId && a.Id == id, trackChanges)
        .FirstOrDefault();
}
