using Entities.Models;

namespace Service.Contracts;

public interface IUniversityService
{
    IEnumerable<University> GetAllUniversities(bool trackChanges);
    University GetUniversity(Guid id, bool trackChanges);

}
