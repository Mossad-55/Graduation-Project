using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface ISubjectService
{
    IEnumerable<SubjectDto> GetAllSubjects(Guid universityId, Guid facultyId, Guid departmentId, bool trackChanges);
    SubjectDto GetSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    SubjectDto CreateSubjectForDepartment(Guid universityId, Guid facultyId, Guid departmentId, SubjectForCreationDto subject, bool trackChanges);
    void DeleteSubjectForDepartment(Guid universityId, Guid facultyId, Guid departmentId, Guid id, bool trackChanges);
    void UpdateSubjectForDepartment(Guid universityId, Guid facultyId, Guid departmentId, Guid id, SubjectForUpdateDto subject, bool otherTrackChanges, bool subTrackChanges);
}
