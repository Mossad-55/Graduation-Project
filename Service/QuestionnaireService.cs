using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class QuestionnaireService : IQuestionnaireService
{
    public QuestionnaireDto CreateQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, QuestionnaireForCreateDto questionnaire, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public void DeleteQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<QuestionnaireDto> GetAllQuestionnaires(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public QuestionnaireDto GetQuestionnaire(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public void UpdateQuestionnaireForSubject(Guid universityId, Guid facultyId, Guid departmentId, Guid subjectId, Guid id, QuestionnaireForUpdateDto questionnaire, bool otherTrackChanges, bool quesTrackChanges)
    {
        throw new NotImplementedException();
    }
}
