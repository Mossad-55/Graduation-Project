using Entities.Models;

namespace Contracts;

public interface ISubjectConclusionRepository
{
    SubjectConclusion GetSubjectConclusionForQuestionnaire(Guid questionnaireId, bool trackChanges);
    SubjectConclusion GetLatestConclusionForSubject(Guid subjectId, bool trackChanges);
}
