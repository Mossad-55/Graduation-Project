using Entities.Models;
using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IUniversityService
{
    IEnumerable<UniversityDto> GetAllUniversities(bool trackChanges);
    UniversityDto GetUniversity(Guid id, bool trackChanges);
    
}
