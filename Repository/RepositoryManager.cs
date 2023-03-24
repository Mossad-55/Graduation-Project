using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IUniversityRepository> _universityRepository;
    private readonly Lazy<IFacultyRepository> _facultyRepository;
    private readonly Lazy<IDepartmentRepository> _departmentRepository;
    


    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _universityRepository = new Lazy<IUniversityRepository>(() => new UniversityRepository(repositoryContext));
        _facultyRepository = new Lazy<IFacultyRepository>(() => new FacultyRepository(repositoryContext));
        _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(repositoryContext));
    }

    public IUniversityRepository University => _universityRepository.Value;
    public IFacultyRepository Faculty => _facultyRepository.Value;
    public IDepartmentRepository Department => _departmentRepository.Value;


    public void Save() => _repositoryContext.SaveChanges();
}
