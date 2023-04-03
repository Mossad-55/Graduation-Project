﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

public class SubjectService : ISubjectService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public SubjectService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public SubjectDto CreateSubjectForDepartment(Guid facultyId, Guid departmentId, SubjectForCreationDto subject, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var subjectEntity = _mapper.Map<Subject>(subject);
        _repository.Subject.CreateSubject(departmentId, subjectEntity);
        _repository.Save();

        var subjectToReturn = _mapper.Map<SubjectDto>(subjectEntity);
        return subjectToReturn;
    }

    public void DeleteSubjectForDepartment(Guid facultyId, Guid departmentId, Guid id, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var subjectEntity = _repository.Subject.GetSubject(departmentId, id, trackChanges);
        if (subjectEntity is null)
            throw new SubjectNotFoundException(id);

        _repository.Subject.DeleteSubject(subjectEntity);
        _repository.Save();
    }

    public IEnumerable<SubjectDto> GetAllSubjects(Guid facultyId, Guid departmentId, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var subjectsFromDb = _repository.Subject.GetAllSubjcets(departmentId, trackChanges);

        var subjectsDto = _mapper.Map<IEnumerable<SubjectDto>>(subjectsFromDb);

        return subjectsDto;
    }

    public SubjectDto GetSubject(Guid facultyId, Guid departmentId, Guid id, bool trackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, trackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var subjectEntity = _repository.Subject.GetSubject(departmentId, id, trackChanges);
        if (subjectEntity is null)
            throw new SubjectNotFoundException(id);

        var subjectToReturn = _mapper.Map<SubjectDto>(subjectEntity);

        return subjectToReturn;
    }

    public void UpdateSubjectForDepartment(Guid facultyId, Guid departmentId, Guid id, SubjectForUpdateDto subject, bool otherTrackChanges, bool subTrackChanges)
    {
        var department = _repository.Department.GetDepartment(facultyId, departmentId, otherTrackChanges);
        if (department is null)
            throw new DepartmentNotFoundException(departmentId);

        var subjectEntity = _repository.Subject.GetSubject(departmentId, id, subTrackChanges);
        if (subjectEntity is null)
            throw new SubjectNotFoundException(id);

        _mapper.Map(subject, subjectEntity);
        _repository.Save();
    }
}
