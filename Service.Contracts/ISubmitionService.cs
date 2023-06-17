using Shared.DataTranferObjects;

namespace Service.Contracts;
public interface ISubmitionService
{
    void AddSubmition(Guid questionnaireId, Guid studentId, SubmitionForCreationDto submition, bool trackChanges);
    bool CheckStudentSubmition(Guid questionnaireId, Guid studentId, bool trackChanges);
}
