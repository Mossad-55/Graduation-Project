namespace Contracts;

public interface IRepositoryManager
{
    // All IRepository Interfaces.
    IUniversityRepository University { get; }
    IFacultyRepository Faculty { get; }
    IDepartmentRepository Department { get; }

    // Shared Functions.
    void Save();
}
