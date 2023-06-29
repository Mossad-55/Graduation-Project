using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

internal sealed class RecommendationRepository : RepositoryBase<Recommendation>, IRecommendationRepository
{
    public RecommendationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public Recommendation GetLatestRecommendationForSubject(Guid subjectId, bool trackChanges) =>
        FindByCondition(r => r.SubjectId == subjectId, trackChanges)
        .OrderByDescending(r => r.Date)
        .Include(r => r.Subject)
        .FirstOrDefault();
}
