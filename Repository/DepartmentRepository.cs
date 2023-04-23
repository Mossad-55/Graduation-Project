using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
{
    public DepartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateDepartmentForFaculty(Guid facultyId, Department department)
    {
        department.FacultyId = facultyId;
        Create(department);
    }

    public void DeleteDepartment(Department department) => Delete(department);

    public IEnumerable<Department> GetAllDepartments(Guid facultyId, bool trackChanges) =>
        FindByCondition(d => d.FacultyId == facultyId, trackChanges)
        .OrderBy(d => d.Name)
        .ToList();

    public Department GetDepartment(Guid facultyId, Guid id, bool trackChanges) =>
        FindByCondition(d => d.FacultyId == facultyId && d.Id == id, trackChanges)
        .FirstOrDefault();

    public Department GetDepartmentById(Guid id, bool trackChanges) =>
        FindByCondition(d => d.Id == id, trackChanges)
        .FirstOrDefault();
}
