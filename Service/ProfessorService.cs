using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Utilities;
using System.Linq.Expressions;

namespace Service;

internal sealed class ProfessorService : IProfessorService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public ProfessorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<ProfessorDto> CreateProfessor(Guid facultyId, Guid departmentId, UserForCreationDto professor, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFacultyById(facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);


        if (await _userManager.FindByEmailAsync(professor.Email) is not null)
            throw new EmailFoundException(professor.Email);

        var user = _mapper.Map<User>(professor);

        var result = await _userManager.CreateAsync(user, professor.Password);
        if (!result.Succeeded)
            throw new UserCreationFailedException(StaticData.ProfessorRole);

        var professorToReturn = _mapper.Map<ProfessorDto>(user);

        var professorEntity = _mapper.Map<Professor>(professorToReturn);

        _repository.Professor.CreateProfessor(faculty.UniversityId, facultyId, departmentId, professorEntity);
        _repository.Save();

        return professorToReturn;
    }

    public async Task DeleteProfessor(Guid id, bool trackChanges)
    {
        var professor = _repository.Professor.GetAProfessor(id, trackChanges);
        if (professor is null)
            throw new UserNotFoundException(id.ToString());

        var user = await _userManager.FindByIdAsync(id.ToString());
        await _userManager.DeleteAsync(user);

        _repository.Professor.DeleteProfessor(professor);
        _repository.Save();
    }

    public async Task<IEnumerable<ProfessorDto>> GetAllProfessorsFilter(Expression<Func<Professor, bool>> expression, bool trackChanges)
    {
        var professors = _repository.Professor.GetAllProfessorsFilter(expression, trackChanges);

        var users = new List<User>();
        foreach (var professor in professors)
        {
            var user = await _userManager.FindByIdAsync(professor.Id.ToString());
            users.Add(user);
        }

        var professorsDto = _mapper.Map<IEnumerable<ProfessorDto>>(users);
        return professorsDto;
    }

    public async Task<ProfessorDto> GetProfessorWithSubjects(Guid id, bool trackChanges)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id.ToString());

        var professorEntity = _repository.Professor.GetAProfessorWithSubjects(id, trackChanges);

        var professorDto = _mapper.Map<ProfessorDto>(user);
        professorDto.Rate = professorEntity.Rate;
        professorDto.Subjects = _mapper.Map<ICollection<SubjectForProfessorDto>>(professorEntity.Subjects);
        

        return professorDto;
    }

    public async Task UpdateProfessor(Guid id, UserForUpdateDto professor, bool trackChanges)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user is null)
            throw new UserNotFoundException(id.ToString());

        _mapper.Map(professor, user);
        _repository.Save();
    }
}
