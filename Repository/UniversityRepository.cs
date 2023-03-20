using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class UniversityRepository : RepositoryBase<University>, IUniversityRepository
{
    
    public UniversityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<University> GetAllUniversities(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(u => u.Name)
        .ToList();

    public University GetUniversity(Guid id, bool trackChanges) =>
        FindByCondition(u => u.Id == id, trackChanges)
        .SingleOrDefault();

    public void DeleteUniversity(University university) => Delete(university);

}
