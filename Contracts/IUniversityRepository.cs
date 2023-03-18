using Entities.Models;

namespace Contracts;

public interface IUniversityRepository
{
    IEnumerable<University> GetAllUniversities(bool trackChanges);
    University GetUniversity(Guid id, bool trackChanges);
    void CreateUniversity(University university);
    void DeleteUniversity(University university);
}
