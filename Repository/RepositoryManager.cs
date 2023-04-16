using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IUniversityRepository> _universityRepository;
    private readonly Lazy<IFacultyRepository> _facultyRepository;
    private readonly Lazy<IDepartmentRepository> _departmentRepository;
    private readonly Lazy<ISubjectRepository> _subjectRepository;
    private readonly Lazy<IQuestionnaireRepository> _questionnaireRepository;
    private readonly Lazy<IUniversityAdminRepository> _universityAdminRepository;
    private readonly Lazy<IFacultyAdminRepository> _facultyAdminRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _universityRepository = new Lazy<IUniversityRepository>(() => new UniversityRepository(repositoryContext));
        _facultyRepository = new Lazy<IFacultyRepository>(() => new FacultyRepository(repositoryContext));
        _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(repositoryContext));
        _subjectRepository = new Lazy<ISubjectRepository>(() => new SubjectRepository(repositoryContext));
        _questionnaireRepository = new Lazy<IQuestionnaireRepository>(() => new QuestionnaireRepository(repositoryContext));
        _universityAdminRepository = new Lazy<IUniversityAdminRepository>(() => new UniversityAdminRepository(repositoryContext));
        _facultyAdminRepository = new Lazy<IFacultyAdminRepository>(() => new FacultyAdminRepository(repositoryContext));
    }

    public IUniversityRepository University => _universityRepository.Value;
    public IFacultyRepository Faculty => _facultyRepository.Value;
    public IDepartmentRepository Department => _departmentRepository.Value;
    public ISubjectRepository Subject => _subjectRepository.Value;
    public IQuestionnaireRepository Questionnaire => _questionnaireRepository.Value;
    public IUniversityAdminRepository UniversityAdmin => _universityAdminRepository.Value;
    public IFacultyAdminRepository FacultyAdmin =>  _facultyAdminRepository.Value;


    public void Save() => _repositoryContext.SaveChanges();
}
