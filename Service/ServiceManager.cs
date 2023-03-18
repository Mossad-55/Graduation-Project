using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IUniversityService> _universityService;

	public ServiceManager(IRepositoryManager repositoryManager, 
		ILoggerManager logger, IMapper mapper)
	{
		_universityService = new Lazy<IUniversityService>(() => new UniversityService(repositoryManager, logger, mapper));
	}

	public IUniversityService UniversityService => _universityService.Value;
}
