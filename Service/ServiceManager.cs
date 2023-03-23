using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IUniversityService> _universityService;
    private readonly Lazy<IFacultyService> _facultyService;

	public ServiceManager(IRepositoryManager repositoryManager, 
		ILoggerManager logger, IMapper mapper)
	{
		_universityService = new Lazy<IUniversityService>(() => new UniversityService(repositoryManager, logger, mapper));
		_facultyService = new Lazy<IFacultyService>(() => new FacultyService(repositoryManager, logger, mapper));
	}

	public IUniversityService UniversityService => _universityService.Value;
	public IFacultyService FacultyService => _facultyService.Value;
}
