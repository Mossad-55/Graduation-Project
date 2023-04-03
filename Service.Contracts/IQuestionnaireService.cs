using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IQuestionnaireService
{
    IEnumerable<QuestionnaireDto> GetAllQuestionnaires(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, bool trackChanges);
    QuestionnaireDto GetQuestionnaire(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, bool trackChanges);
    QuestionnaireDto CreateQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, QuestionnaireForCreateDto questionnaire, bool trackChanges);
    void DeleteQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, bool trackChanges);
    void UpdateQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, QuestionnaireForUpdateDto questionnaire, bool otherTrackChanges, bool quesTrackChanges);
}
