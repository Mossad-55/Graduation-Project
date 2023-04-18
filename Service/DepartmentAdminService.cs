using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Utilities;

namespace Service;

internal sealed class DepartmentAdminService : IDepartmentAdminService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public DepartmentAdminService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<AdminDto> CreateAdminForDepartment(Guid universityId, Guid facultyId, Guid departmentId, AdminForCreationDto admin, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        if (await _userManager.FindByEmailAsync(admin.Email) is not null)
            throw new EmailFoundException(admin.Email);

        var user = _mapper.Map<User>(admin);

        var result = await _userManager.CreateAsync(user, admin.Password);
        if (!result.Succeeded)
            throw new UserCreationFailedException(StaticData.DepartmentAdminRole);

        await _userManager.AddToRoleAsync(user, StaticData.DepartmentAdminRole);

        var adminToReturn = _mapper.Map<AdminDto>(user);

        var departmentAdmin = _mapper.Map<DepartmentAdmin>(adminToReturn);

        _repository.DepartmentAdmin.CreateDepartmentAdmin(universityId, facultyId, departmentId, departmentAdmin);
        _repository.Save();

        return adminToReturn;
    }

    public async Task DeleteAdminForDepartment(Guid facultyId, Guid departmentId, Guid id, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        await _userManager.DeleteAsync(user);

        var departmentAdmin = _mapper.Map<DepartmentAdmin>(user);
        _repository.DepartmentAdmin.DeleteDepartmentAdmin(departmentAdmin);
        _repository.Save();
    }

    public async Task<IEnumerable<AdminDto>> GetAllAdmins(Guid facultyId, Guid departmentId, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var departmentAdmins = _repository.DepartmentAdmin.GetAllDepartmentAdmins(departmentId, trackChanges);

        var users = new List<User>();
        foreach (var admin in departmentAdmins)
        {
            var user = await _userManager.FindByIdAsync(admin.Id.ToString());
            users.Add(user);
        }

        var departmentAdminsDto = _mapper.Map<IEnumerable<AdminDto>>(users);
        return departmentAdminsDto;
    }

    public async Task<AdminDto> GetDepartmentAdmin(Guid facultyId, Guid departmentId, Guid id, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        var adminDto = _mapper.Map<AdminDto>(user);
        return adminDto;
    }

    public async Task UpdateAdminForDepartment(Guid facultyId, Guid departmentId, Guid id, AdminForUpdateDto admin, bool othTrackChanges, bool admTrackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        _mapper.Map(admin, user);
        _repository.Save();
    }
}
