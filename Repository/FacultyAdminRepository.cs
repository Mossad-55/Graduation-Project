using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class FacultyAdminRepository : RepositoryBase<FacultyAdmin>, IFacultyAdminRepository
{
    public FacultyAdminRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateFacultyAdmin(Guid facultyId, FacultyAdmin facultyAdmin)
    {
        facultyAdmin.FacultyId = facultyId;
        Create(facultyAdmin);
    }

    public void DeleteFacultyAdmin(FacultyAdmin facultyAdmin) => Delete(facultyAdmin);

    public IEnumerable<FacultyAdmin> GetAllFacultyAdmins(Guid facultyId, bool trackChanges) =>
        FindByCondition(a => a.FacultyId == facultyId, trackChanges)
        .OrderBy(a => a.FullName)
        .ToList();

    public FacultyAdmin GetFacultyAdmin(Guid facultyId, Guid id, bool trackChanges) =>
        FindByCondition(a => a.FacultyId == facultyId && a.Id == id, trackChanges)
        .FirstOrDefault();
}
