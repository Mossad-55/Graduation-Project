using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class FacultyService : IFacultyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public FacultyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<FacultyDto> GetAllFaculities(Guid universityId, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var facultyFromDb = _repository.Faculty.GetAllFaculitites(universityId, trackChanges);
        var facultyDto = _mapper.Map<IEnumerable<FacultyDto>>(facultyFromDb);

        return facultyDto;
    }

    public FacultyDto GetFaculty(Guid universityId, Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var facultyFromDb = _repository.Faculty.GetFaculty(universityId, id, trackChanges);
        if (facultyFromDb is null)
            throw new FacultyNotFoundException(id);

        var facultyDto = _mapper.Map<FacultyDto>(facultyFromDb);
        return facultyDto;
    }

    public FacultyDto CreateFacultyForUniversity(Guid universityId, FacultyForCreationDto faculty, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var facultyEntity = _mapper.Map<Faculty>(faculty);

        _repository.Faculty.CreateFacultyForUniversity(universityId, facultyEntity);
        _repository.Save();

        var facultyToReturn = _mapper.Map<FacultyDto>(facultyEntity);
        return facultyToReturn;
    }

    public void DeleteFacultyForUniversity(Guid universityId, Guid id, bool trackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, trackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var facultyForUniversity = _repository.Faculty.GetFaculty(universityId, id, trackChanges);
        if (facultyForUniversity is null)
            throw new FacultyNotFoundException(id);

        _repository.Faculty.DeleteFaculty(facultyForUniversity);
        _repository.Save();
    }

    public void UpdateFacultyForUniversity(Guid universityId, Guid id, FacultyForUpdateDto faculty, bool uniTrackChanges, bool facTrackChanges)
    {
        var university = _repository.University.GetUniversity(universityId, uniTrackChanges);
        if (university is null)
            throw new UniversityNotFoundException(universityId);

        var facultyEntity = _repository.Faculty.GetFaculty(universityId, id, facTrackChanges);
        if (facultyEntity is null)
            throw new FacultyNotFoundException(id);

        _mapper.Map(faculty, facultyEntity);
        _repository.Save();
    }
}
