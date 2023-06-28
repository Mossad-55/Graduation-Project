using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class SubjectConclusionService : ISubjectConclusionService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    private readonly ILoggerManager _logger;
    public SubjectConclusionService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public SubjectConclusionDto GetLatestConclusionForSubject(Guid subjectId, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubjectById(subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var subjectConclusion = _repository.SubjectConclusion.GetLatestConclusionForSubject(subjectId, trackChanges);
        if (subjectConclusion is null)
            return null;

        var subjectConclusionDto = _mapper.Map<SubjectConclusionDto>(subjectConclusion);

        return subjectConclusionDto;
    }
}
