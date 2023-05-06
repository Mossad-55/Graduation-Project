using Shared.DataTranferObjects;

namespace Service.Contracts;
public interface ISubmitionService
{
    IEnumerable<SubmitionDto> GetSubmitionsForQuestionnaire(Guid questionnaireId, bool trackChanges);

    void AddSubmition(Guid questionnaireId, Guid studentId, SubmitionForCreationDto submition, bool trackChanges);
}
