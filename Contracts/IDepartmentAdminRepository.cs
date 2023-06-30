using Entities.Models;

namespace Contracts;

public interface IDepartmentAdminRepository
{
    IEnumerable<DepartmentAdmin> GetAllDepartmentAdmins(Guid departmentId, bool trackChanges);
    DepartmentAdmin GetDepartmentAdmin(Guid departmentId, Guid id, bool trackChanges);
    DepartmentAdmin GetDepartmentAdminById(Guid id, bool trackChanges);
    void CreateDepartmentAdmin(Guid universityId, Guid facultyId, Guid departmentId, DepartmentAdmin departmentAdmin);
    void DeleteDepartmentAdmin(DepartmentAdmin departmentAdmin);
}
