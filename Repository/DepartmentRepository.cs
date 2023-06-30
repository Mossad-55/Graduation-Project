using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

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

    public IEnumerable<Department> GetAllDepartmentsWithSubjects(Guid facultyId, bool trackChanges)
    {
        var departments = FindByCondition(d => d.FacultyId == facultyId, trackChanges)
            .Include(d => d.Subjects)
            .ToList();

        foreach (var department in departments)
        {
            department.Subjects = department.Subjects.Where(s => s.Rate <= 3).ToList();
        }

        return departments.Where(x => x.Subjects.Count > 0);
    }

    public Department GetDepartment(Guid facultyId, Guid id, bool trackChanges) =>
        FindByCondition(d => d.FacultyId == facultyId && d.Id == id, trackChanges)
        .FirstOrDefault();

    public Department GetDepartmentById(Guid id, bool trackChanges) =>
        FindByCondition(d => d.Id == id, trackChanges)
        .FirstOrDefault();
}
