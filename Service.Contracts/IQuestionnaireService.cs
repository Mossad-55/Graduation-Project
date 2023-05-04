using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IQuestionnaireService
{
    IEnumerable<QuestionnaireDto> GetAllQuestionnaires(Guid departmentId, Guid subjectId, bool trackChanges);
    QuestionnaireDto GetQuestionnaire(Guid departmentId, Guid subjectId, Guid id, bool trackChanges);
    QuestionnaireDto GetQuestionnaireById(Guid id, bool trackChanges);
    QuestionnaireDto CreateQuestionnaireForSubject(Guid departmentId, Guid subjectId, QuestionnaireForCreationDto questionnaire, bool trackChanges);
    void DeleteQuestionnaireForSubject(Guid departmentId, Guid subjectId, Guid id, bool trackChanges);
    void UpdateQuestionnaireForSubject(Guid departmentId, Guid subjectId, Guid id, QuestionnaireForUpdateDto questionnaire, bool otherTrackChanges, bool quesTrackChanges);
}
