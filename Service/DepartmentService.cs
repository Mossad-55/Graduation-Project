using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class DepartmentService : IDepartmentService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public DepartmentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public DepartmentDto CreateDepartmentForFaculty(Guid universityId, Guid facultyId, DepartmentForCreateDto department, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentEntity = _mapper.Map<Department>(department);
        
        _repository.Department.CreateDepartmentForFaculty(facultyId, departmentEntity);
        _repository.Save();

        var departmentToReturn = _mapper.Map<DepartmentDto>(departmentEntity);
        return departmentToReturn;
    }

    public void DeleteDepartmentForFaculty(Guid universityId, Guid facultyId, Guid id, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentForFaculty = _repository.Department.GetDepartment(facultyId, id, trackChanges);
        if (departmentForFaculty is null)
            throw new DepartmentNotFoundException(id);

        _repository.Department.DeleteDepartment(departmentForFaculty);
        _repository.Save();
    }

    public IEnumerable<DepartmentDto> GetAllDepartments(Guid universityId, Guid facultyId, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentsFromDb = _repository.Department.GetAllDepartments(facultyId, trackChanges);

        var departmentsDto = _mapper.Map<IEnumerable<DepartmentDto>>(departmentsFromDb);

        return departmentsDto;
    }

    public IEnumerable<DepartmentWithSubjectsDto> GetAllDepartmentsWithSubjects(Guid universityId, Guid facultyId, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentsFromDb = _repository.Department.GetAllDepartmentsWithSubjects(facultyId, trackChanges);

        var departmentsDto = _mapper.Map<IEnumerable<DepartmentWithSubjectsDto>>(departmentsFromDb);

        return departmentsDto;
    }

    public DepartmentDto GetDepartment(Guid universityId, Guid facultyId, Guid id, bool trackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, trackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentFromDb = _repository.Department.GetDepartment(facultyId, id, trackChanges);
        if (departmentFromDb is null)
            throw new DepartmentNotFoundException(id);

        var departmentDto = _mapper.Map<DepartmentDto>(departmentFromDb);

        return departmentDto;
    }

    public void UpdateDepartmentForFaculty(Guid universityId, Guid facultyId, Guid id, DepartmentForUpdateDto department, bool facTrackChanges, bool depTrackChanges)
    {
        var faculty = _repository.Faculty.GetFaculty(universityId, facultyId, facTrackChanges);
        if (faculty is null)
            throw new FacultyNotFoundException(facultyId);

        var departmentEntity = _repository.Department.GetDepartment(facultyId, id, depTrackChanges);
        if (departmentEntity is null)
            throw new DepartmentNotFoundException(id);

        _mapper.Map(department, departmentEntity);
        _repository.Save();
    }
}
