using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IUniversityService> _universityService;
    private readonly Lazy<IFacultyService> _facultyService;
    private readonly Lazy<IDepartmentService> _departmentService;
    private readonly Lazy<ISubjectService> _subjectService;
    private readonly Lazy<IQuestionnaireService> _questionnaireService;

	public ServiceManager(IRepositoryManager repositoryManager, 
		ILoggerManager logger, IMapper mapper)
	{
		_universityService = new Lazy<IUniversityService>(() => new UniversityService(repositoryManager, logger, mapper));
		_facultyService = new Lazy<IFacultyService>(() => new FacultyService(repositoryManager, logger, mapper));
		_departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(repositoryManager, logger, mapper));
		_subjectService = new Lazy<ISubjectService>(() => new SubjectService(repositoryManager, logger, mapper));
		_questionnaireService = new Lazy<IQuestionnaireService>(() => new QuestionnaireService(repositoryManager, logger, mapper));
	}

	public IUniversityService UniversityService => _universityService.Value;
	public IFacultyService FacultyService => _facultyService.Value;
	public IDepartmentService DepartmentService => _departmentService.Value;
	public ISubjectService SubjectService => _subjectService.Value;
	public IQuestionnaireService QuestionnaireService => _questionnaireService.Value;
}
