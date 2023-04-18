using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IUniversityService> _universityService;
    private readonly Lazy<IFacultyService> _facultyService;
    private readonly Lazy<IDepartmentService> _departmentService;
    private readonly Lazy<ISubjectService> _subjectService;
    private readonly Lazy<IQuestionnaireService> _questionnaireService;
    private readonly Lazy<IUniversityAdminService> _universityAdminService;
    private readonly Lazy<IFacultyAdminService> _facultyAdminService;
    private readonly Lazy<IDepartmentAdminService> _departmentAdminService;

	public ServiceManager(IRepositoryManager repositoryManager, 
		ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
	{
		_universityService = new Lazy<IUniversityService>(() => new UniversityService(repositoryManager, logger, mapper));
		_facultyService = new Lazy<IFacultyService>(() => new FacultyService(repositoryManager, logger, mapper));
		_departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(repositoryManager, logger, mapper));
		_subjectService = new Lazy<ISubjectService>(() => new SubjectService(repositoryManager, logger, mapper));
		_questionnaireService = new Lazy<IQuestionnaireService>(() => new QuestionnaireService(repositoryManager, logger, mapper));
		_universityAdminService = new Lazy<IUniversityAdminService>(() => new UniversityAdminService(repositoryManager, logger, mapper, userManager));
		_facultyAdminService = new Lazy<IFacultyAdminService>(() => new FacultyAdminService(repositoryManager, logger, mapper, userManager));
		_departmentAdminService = new Lazy<IDepartmentAdminService>(() => new DepartmentAdminService(repositoryManager, logger, mapper, userManager));
	}

	public IUniversityService UniversityService => _universityService.Value;
	public IFacultyService FacultyService => _facultyService.Value;
	public IDepartmentService DepartmentService => _departmentService.Value;
	public ISubjectService SubjectService => _subjectService.Value;
	public IQuestionnaireService QuestionnaireService => _questionnaireService.Value;
	public IUniversityAdminService UniversityAdminService => _universityAdminService.Value;
	public IFacultyAdminService FacultyAdminService => _facultyAdminService.Value;
	public IDepartmentAdminService DepartmentAdminService => _departmentAdminService.Value;
}
