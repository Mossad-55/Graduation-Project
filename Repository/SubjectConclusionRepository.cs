using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class SubjectConclusionRepository : RepositoryBase<SubjectConclusion>, ISubjectConclusionRepository
{
    public SubjectConclusionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public SubjectConclusion GetLatestConclusionForSubject(Guid subjectId, bool trackChanges) =>
        FindByCondition(sc => sc.SubjectId == subjectId, trackChanges)
        .OrderByDescending(sc => sc.Date)
        .FirstOrDefault();

    public SubjectConclusion GetSubjectConclusionForQuestionnaire(Guid questionnaireId, bool trackChanges) =>
        FindByCondition(sc => sc.QuestionnaireId == questionnaireId, trackChanges)
        .FirstOrDefault();
}
