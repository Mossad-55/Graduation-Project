using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Utilities;

namespace Service;

internal sealed class UniversityAdminService : IUniversityAdminService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public UniversityAdminService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<UserDto> CreateAdminForUniversity(Guid universityId, UserForCreationDto admin, bool trackChanges)
    {
        // Check for university
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        // Check if the email exists or not.
        if (await _userManager.FindByEmailAsync(admin.Email) is not null)
            throw new EmailFoundException(admin.Email);

        // Mapping from DTO to the User Entity.
        var user = _mapper.Map<User>(admin);

        // Creating the user and hashing the passowrd.
        var result = await _userManager.CreateAsync(user, admin.Password);
        if (!result.Succeeded) 
            throw new UserCreationFailedException(StaticData.UniversityAdminRole); 

        await _userManager.AddToRoleAsync(user, StaticData.UniversityAdminRole); 
        
        var universityAdminToReturn = _mapper.Map<UserDto>(user);

        var universityAdmin = _mapper.Map<UniversityAdmin>(universityAdminToReturn);
        universityAdmin.UniversityId = universityId;

        _repository.UniversityAdmin.CreateUniversityAdmin(universityId, universityAdmin);
        _repository.Save();

        return universityAdminToReturn;
    }

    public async Task DeleteAdminForUniversity(Guid universityId, Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        await _userManager.DeleteAsync(user);
        var universityAdmin = _mapper.Map<UniversityAdmin>(user);
        _repository.UniversityAdmin.DeleteUniversityAdmin(universityAdmin);
        _repository.Save();
    }

    public async Task<IEnumerable<UserDto>> GetAllAdmins(Guid universityId, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var universityAdmins = _repository.UniversityAdmin.GetAllUniversityAdmins(universityId, trackChanges);

        var users = new List<User>();
        foreach (var admin in universityAdmins)
        {
            var user = await _userManager.FindByIdAsync(admin.Id.ToString());
            users.Add(user);
        }
        
        var universityAdminsDto = _mapper.Map<IEnumerable<UserDto>>(users);
        return universityAdminsDto;

    }

    public async Task<UserDto> GetUniveristyAdmin(Guid universityId, Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        var universityAdminDto = _mapper.Map<UserDto>(user);
        return universityAdminDto;
    }

    public async Task UpdateAdminForUniversity(Guid universityId, Guid id, UserForUpdateDto admin, bool uniTrackChanges, bool admTrackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, uniTrackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        _mapper.Map(admin, user);
        _repository.Save();
    }
}
