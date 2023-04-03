using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface ISubjectService
{
    IEnumerable<SubjectDto> GetAllSubjects(Guid facultyId, Guid departmentId, bool trackChanges);
    SubjectDto GetSubject(Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    SubjectDto CreateSubjectForDepartment(Guid facultyId, Guid departmentId, SubjectForCreationDto subject, bool trackChanges);
    void DeleteSubjectForDepartment(Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    void UpdateSubjectForDepartment(Guid facultyId, Guid departmentId, Guid id, SubjectForUpdateDto subject, bool otherTrackChanges, bool subTrackChanges);
}
