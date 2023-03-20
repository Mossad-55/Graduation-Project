using Entities.Models;
using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IUniversityService
{
    IEnumerable<UniversityDto> GetAllUniversities(bool trackChanges);
    UniversityDto GetUniversity(Guid id, bool trackChanges);
    void DeleteUniversity(Guid universityId, bool trackChanges);
}
