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

    public async Task<AdminDto> CreateAdminForUniversity(Guid universityId, AdminForCreationDto admin, bool trackChanges)
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
            throw new UserCreationFailedException(StaticData.UniversityAdminRole); // Change this later when adding static class.

        await _userManager.AddToRoleAsync(user, StaticData.UniversityAdminRole); // Change this later when adding static class.

        var universityAdminToReturn = _mapper.Map<AdminDto>(user);

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

    public async Task<IEnumerable<AdminDto>> GetAllAdmins(Guid universityId, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var universityAdmins = _repository.UniversityAdmin.GetAllUniversityAdmins(universityId, trackChanges);

        var users = Enumerable.Empty<User>();
        foreach (var admin in universityAdmins)
        {
            var user = await _userManager.FindByIdAsync(admin.Id.ToString());
            users.Append(user);
        }

        var universityAdminsDto = _mapper.Map<IEnumerable<AdminDto>>(users);
        return universityAdminsDto;
    }

    public async Task<AdminDto> GetUniveristyAdmin(Guid universityId, Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        var universityAdminDto = _mapper.Map<AdminDto>(user);
        return universityAdminDto;
    }

    public async Task UpdateAdminForUniversity(Guid universityId, Guid id, AdminForUpdateDto admin, bool uniTrackChanges, bool admTrackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, uniTrackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        _mapper.Map(admin, user);
        await _userManager.UpdateAsync(user);
        var universityAdmin = _repository.UniversityAdmin.GetUniversityAdmin(universityId, id, admTrackChanges);
        _mapper.Map(user, universityAdmin);
        _repository.Save();
    }
}
