using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class DepartmentAdminRepository : RepositoryBase<DepartmentAdmin>, IDepartmentAdminRepository
{
    public DepartmentAdminRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateDepartmentAdmin(Guid universityId, Guid facultyId, Guid departmentId, DepartmentAdmin departmentAdmin)
    {
        departmentAdmin.UniveristyId = universityId;
        departmentAdmin.FacultyId = facultyId;
        departmentAdmin.DepartmentId = departmentId;
        Create(departmentAdmin);
    }

    public void DeleteDepartmentAdmin(DepartmentAdmin departmentAdmin) => Delete(departmentAdmin);

    public IEnumerable<DepartmentAdmin> GetAllDepartmentAdmins(Guid departmentId, bool trackChanges) =>
        FindByCondition(a => a.DepartmentId == departmentId, trackChanges)
        .ToList();

    public DepartmentAdmin GetDepartmentAdmin(Guid departmentId, Guid id, bool trackChanges) =>
        FindByCondition(a => a.DepartmentId == departmentId && a.Id == id, trackChanges)
        .FirstOrDefault();
}
