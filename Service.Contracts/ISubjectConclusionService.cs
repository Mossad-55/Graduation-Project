using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface ISubjectConclusionService
{
    SubjectConclusionDto GetLatestConclusionForSubject(Guid subjectId, bool trackChanges);
    SubjectConclusionDto GetConclusionForQuestionnaire(Guid questionnaireId, bool trackChanges);
}
