using Entities.Models;

namespace Contracts;

public interface ISubmitionRepository
{
    bool CheckForStudentSubmition(Guid questionnaireId, Guid studentId, bool trackChanges);
    void AddSubmition(Guid questionnaireId, Guid studentId, Submition submition);
}