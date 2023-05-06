using Entities.Models;

namespace Contracts;

public interface ISubmitionRepository
{
    IEnumerable<Submition> GetSubmitionsForQuestionnaire(Guid questionnaireId, bool trackChanges);
    bool CheckForStudentSubmition(Guid questionnaireId, Guid studentId, bool trackChanges);

    void AddSubmition(Guid questionnaireId, Guid studentId, Submition submition);
}