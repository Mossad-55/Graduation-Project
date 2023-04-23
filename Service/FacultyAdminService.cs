﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Utilities;

namespace Service;

internal sealed class FacultyAdminService : IFacultyAdminService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public FacultyAdminService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<UserDto> CreateAdminForFaculty(Guid facultyId, UserForCreationDto admin, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        if (await _userManager.FindByEmailAsync(admin.Email) is not null)
            throw new EmailFoundException(admin.Email);

        var user = _mapper.Map<User>(admin);

        var result = await _userManager.CreateAsync(user, admin.Password);
        if (!result.Succeeded)
            throw new UserCreationFailedException(StaticData.FacultyAdminRole); 

        await _userManager.AddToRoleAsync(user, StaticData.FacultyAdminRole); 

        var facultyAdminToReturn = _mapper.Map<UserDto>(user);

        var facultyAdmin = _mapper.Map<FacultyAdmin>(facultyAdminToReturn);

        _repository.FacultyAdmin.CreateFacultyAdmin(faculty.UniversityId, facultyId, facultyAdmin);
        _repository.Save();

        return facultyAdminToReturn;
    }

    public async Task DeleteAdminForFaculty(Guid facultyId, Guid id, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        await _userManager.DeleteAsync(user);

        var facultyAdmin = _mapper.Map<FacultyAdmin>(user);
        _repository.FacultyAdmin.DeleteFacultyAdmin(facultyAdmin);
        _repository.Save();
    }

    public async Task<IEnumerable<UserDto>> GetAllAdmins(Guid facultyId, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var facultyAdmins = _repository.FacultyAdmin.GetAllFacultyAdmins(facultyId, trackChanges);

        var users = new List<User>();
        foreach (var admin in facultyAdmins)
        {
            var user = await _userManager.FindByIdAsync(admin.Id.ToString());
            users.Add(user);
        }

        var facultyAdminsDto = _mapper.Map<IEnumerable<UserDto>>(users);
        return facultyAdminsDto;
    }

    public async Task<UserDto> GetFacultyAdmin(Guid facultyId, Guid id, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        var adminDto = _mapper.Map<UserDto>(user);
        return adminDto;
    }

    public async Task UpdateAdminForFaculty(Guid facultyId, Guid id, UserForUpdateDto admin, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id);

        _mapper.Map(admin, user);
        _repository.Save();
    }
}
