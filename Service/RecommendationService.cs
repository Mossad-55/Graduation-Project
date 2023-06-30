using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class RecommendationService : IRecommendationService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public RecommendationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public List<RecommendationDto> GetRecommendationsForProfessor(Guid professorId, bool trackChanges)
    {
        var professor = _repository.Professor.GetAProfessorWithSubjects(professorId, trackChanges);
        if (professor is null)
            throw new UserNotFoundException(professorId.ToString());

        List<RecommendationDto> recommendationsDto = new();

        foreach (var subject in professor.Subjects)
        {
            var recommendation = _repository.Recommendation.GetLatestRecommendationForSubject(subject.Id, trackChanges);
            if (recommendation is null)
                continue;

            var recommendationDto = _mapper.Map<RecommendationDto>(recommendation);

            recommendationsDto.Add(recommendationDto);
        }

        return recommendationsDto;
    }
}
