using Entities.Models;

namespace Contracts;

public interface IFacultyRepository
{
    IEnumerable<Faculty> GetAllFaculitites(Guid universityId, bool trackChanges);
    Faculty GetFaculty(Guid universityId, Guid id, bool trackChanges);
    void CreateFacultyForUniversity(Guid universityId, Faculty faculty);
    void DeleteFaculty(Faculty faculty);
}
