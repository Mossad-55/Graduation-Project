namespace Contracts;

public interface IRepositoryManager
{
    // All IRepository Interfaces.
    IUniversityRepository University { get; }
    IFacultyRepository Faculty { get; }
    IDepartmentRepository Department { get; }
    ISubjectRepository Subject { get; }

    // Shared Functions.
    void Save();
}
