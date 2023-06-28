using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
{
    public SubjectRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateSubject(Guid departmentId, Subject subject)
    {
        subject.DepartmentId = departmentId;
        Create(subject);
    }

    public void DeleteSubject(Subject subject) => Delete(subject);

    public IEnumerable<Subject> GetAllSubjcets(Guid departmentId, bool trackChanges) =>
        FindByCondition(s => s.DepartmentId == departmentId, trackChanges)
        .OrderBy(s => s.Name)
        .ToList();

    public Subject GetSubject(Guid departmentId, Guid id, bool trackChanges) =>
        FindByCondition(s => s.DepartmentId == departmentId && s.Id == id, trackChanges)
        .FirstOrDefault();

    public Subject GetSubjectById(Guid subjectId, bool trackChanges) =>
        FindByCondition(s => s.Id == subjectId, trackChanges)
        .FirstOrDefault();
}
