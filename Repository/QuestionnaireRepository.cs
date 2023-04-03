using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class QuestionnaireRepository : RepositoryBase<Questionnaire>, IQuestionnaireRepository
{
    public QuestionnaireRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateQuestionnaire(Guid subjectId, Questionnaire questionnaire)
    {
        questionnaire.SubjectId = subjectId;
        Create(questionnaire);
    }

    public void DeleteQuestionnaire(Questionnaire questionnaire) => Delete(questionnaire);

    public IEnumerable<Questionnaire> GetAllQuestionnaires(Guid subjectId, bool trackChanges) =>
        FindByCondition(q => q.SubjectId == subjectId, trackChanges)
        .OrderBy(q => q.CreatedAt)
        .ToList();

    public Questionnaire GetQuestionnaire(Guid subjectId, Guid id, bool trackChanges) =>
        FindByCondition(q => q.SubjectId == subjectId && q.Id == id, trackChanges)
        .FirstOrDefault();
}
