using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IDepartmentService
{
    IEnumerable<DepartmentDto> GetAllDepartments(Guid universityId, Guid facultyId, bool trackChanges);
    DepartmentDto GetDepartment(Guid universityId, Guid facultyId, Guid id, bool trackChanges);
    IEnumerable<DepartmentWithSubjectsDto> GetAllDepartmentsWithSubjects(Guid universityId, Guid facultyId, bool trackChanges);
    DepartmentDto CreateDepartmentForFaculty(Guid universityId, Guid facultyId, DepartmentForCreateDto department, bool trackChanges);
    void DeleteDepartmentForFaculty(Guid universityId, Guid facultyId, Guid id, bool trackChanges);
    void UpdateDepartmentForFaculty(Guid universityId, Guid facultyId, Guid id, DepartmentForUpdateDto department, bool facTrackChanges, bool depTrackChanges);
}
