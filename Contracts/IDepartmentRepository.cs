using Entities.Models;

namespace Contracts;

public interface IDepartmentRepository
{
    IEnumerable<Department> GetAllDepartments(Guid facultyId, bool trackChanges);
    IEnumerable<Department> GetAllDepartmentsWithSubjects(Guid facultyId, bool trackChanges);
    Department GetDepartment(Guid facultyId, Guid id, bool trackChanges);
    Department GetDepartmentById(Guid id, bool trackChanges);
    void CreateDepartmentForFaculty(Guid facultyId, Department department);
    void DeleteDepartment(Department department);
}
