using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class FacultyRepository : RepositoryBase<Faculty>, IFacultyRepository
{
    public FacultyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateFacultyForUniversity(Guid universityId, Faculty faculty)
    {
        faculty.UniversityId = universityId;
        Create(faculty);
    }

    public void DeleteFaculty(Faculty faculty) => Delete(faculty);

    public IEnumerable<Faculty> GetAllFaculitites(Guid universityId, bool trackChanges) =>
        FindByCondition(f => f.UniversityId == universityId, trackChanges)
        .OrderBy(f => f.Name)
        .ToList();

    public Faculty GetFaculty(Guid universityId, Guid id, bool trackChange) =>
        FindByCondition(f => f.UniversityId == universityId && f.Id == id, trackChange)
        .FirstOrDefault();
}
