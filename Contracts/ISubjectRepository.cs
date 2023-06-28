using Entities.Models;

namespace Contracts;

public interface ISubjectRepository
{
    IEnumerable<Subject> GetAllSubjcets(Guid departmentId, bool trackChanges);
    Subject GetSubject(Guid departmentId, Guid id, bool trackChanges);
    Subject GetSubjectById(Guid subjectId, bool trackChanges);
    void CreateSubject(Guid departmentId, Subject subject);
    void DeleteSubject(Subject subject);
}
