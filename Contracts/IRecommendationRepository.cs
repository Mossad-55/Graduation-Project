using Entities.Models;

namespace Contracts;

public interface IRecommendationRepository
{
    Recommendation GetLatestRecommendationForSubject(Guid subjectId, bool trackChanges);
}
