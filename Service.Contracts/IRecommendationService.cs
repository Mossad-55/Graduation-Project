using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IRecommendationService
{
    List<RecommendationDto> GetRecommendationsForProfessor(Guid professorId, bool trackChanges);
}
