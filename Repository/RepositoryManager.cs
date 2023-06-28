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
    private readonly Lazy<IDepartmentAdminRepository> _departmentAdminRepository;
    private readonly Lazy<IProfessorRepository> _professorRepository;
    private readonly Lazy<IStudentRepository> _studentRepository;
    private readonly Lazy<ISubmitionRepository> _submitionRepository;
    private readonly Lazy<IFacultyAnalysisRepository> _facultyAnalysisRepository;
    private readonly Lazy<IDepartmentAnalysisRepository> _departmentAnalysisRepository;
    private readonly Lazy<ISubjectAnalysisRepository> _subjectAnalysisRepository;
    private readonly Lazy<ISubjectConclusionRepository> _subjectConclusionRepository;
    private readonly Lazy<IRecommendationRepository> _recommendationRepository;

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
        _departmentAdminRepository = new Lazy<IDepartmentAdminRepository>(() => new DepartmentAdminRepository(repositoryContext));
        _professorRepository = new Lazy<IProfessorRepository>(() => new ProfessorRepository(repositoryContext));
        _studentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(repositoryContext));
        _submitionRepository = new Lazy<ISubmitionRepository>(() => new SubmitionRepository(repositoryContext));
        _facultyAnalysisRepository = new Lazy<IFacultyAnalysisRepository>(() => new FacultyAnalysisRepository(repositoryContext));
        _departmentAnalysisRepository = new Lazy<IDepartmentAnalysisRepository>(() => new DepartmentAnalysisRepository(repositoryContext));
        _subjectAnalysisRepository = new Lazy<ISubjectAnalysisRepository>(() => new SubjectAnalysisRepository(repositoryContext));
        _subjectConclusionRepository = new Lazy<ISubjectConclusionRepository>(() => new SubjectConclusionRepository(repositoryContext));
        _recommendationRepository = new Lazy<IRecommendationRepository>(() => new RecommendationRepository(repositoryContext));
    }

    public IUniversityRepository University => _universityRepository.Value;
    public IFacultyRepository Faculty => _facultyRepository.Value;
    public IDepartmentRepository Department => _departmentRepository.Value;
    public ISubjectRepository Subject => _subjectRepository.Value;
    public IQuestionnaireRepository Questionnaire => _questionnaireRepository.Value;
    public IUniversityAdminRepository UniversityAdmin => _universityAdminRepository.Value;
    public IFacultyAdminRepository FacultyAdmin => _facultyAdminRepository.Value;
    public IDepartmentAdminRepository DepartmentAdmin => _departmentAdminRepository.Value;
    public IProfessorRepository Professor => _professorRepository.Value;
    public IStudentRepository Student => _studentRepository.Value;
    public ISubmitionRepository Submition => _submitionRepository.Value;
    public IFacultyAnalysisRepository FacultyAnalysis => _facultyAnalysisRepository.Value;
    public IDepartmentAnalysisRepository DepartmentAnalysis => _departmentAnalysisRepository.Value;
    public ISubjectAnalysisRepository SubjectAnalysis => _subjectAnalysisRepository.Value;
    public ISubjectConclusionRepository SubjectConclusion => _subjectConclusionRepository.Value;
    public IRecommendationRepository Recommendation =>  _recommendationRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}
