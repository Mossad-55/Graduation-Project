using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class SubmitionRepository : RepositoryBase<Submition>, ISubmitionRepository
{
    public SubmitionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void AddSubmition(Guid questionnaireId, Guid studentId, Submition submition)
    {
        submition.StudentId = studentId;
        submition.QuestionnaireId = questionnaireId;
        Create(submition);
    }

    public bool CheckForStudentSubmition(Guid questionnaireId, Guid studentId, bool trackChanges) =>
        FindByCondition(q => q.QuestionnaireId == questionnaireId && q.StudentId == studentId, trackChanges)
        .FirstOrDefault() != null;

    public IEnumerable<Submition> GetSubmitionsForQuestionnaire(Guid questionnaireId, bool trackChanges) =>
        FindByCondition(s => s.QuestionnaireId == questionnaireId, trackChanges)
        .ToList();
}
