﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTranferObjects;
using System.Diagnostics;

namespace Service;

internal sealed class UniversityService : IUniversityService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public UniversityService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public void DeleteCompany(Guid universityId, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        _repository.University.DeleteUniversity(university);
        _repository.Save();
    }

    public IEnumerable<UniversityDto> GetAllUniversities(bool trackChanges)
    {
        var universities = _repository.University.GetAllUniversities(trackChanges);

        var universitiesDto = _mapper.Map<IEnumerable<UniversityDto>>(universities);

        return universitiesDto;
    }

    public UniversityDto GetUniversity(Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(id, trackChanges);

        if (university is null)
            throw new UniversityNotFoundException(id);

        var universityDto = _mapper.Map<UniversityDto>(university);

        return universityDto;
    }
}
