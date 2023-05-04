using Entities.Models;

namespace Contracts;

public interface IQuestionnaireRepository
{
    IEnumerable<Questionnaire> GetAllQuestionnaires(Guid subjectId, bool trackChanges);
    Questionnaire GetQuestionnaire(Guid subjectId, Guid id, bool trackChanges);
    Questionnaire GetQuestionnaireById(Guid id, bool trackChanges);
    void CreateQuestionnaire(Guid subjectId, Questionnaire questionnaire);
    void DeleteQuestionnaire(Questionnaire questionnaire);
}
