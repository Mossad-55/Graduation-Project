using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class SubjectAnalysisRepository : RepositoryBase<SubjectAnalysis>, ISubjectAnalysisRepository
{
    public SubjectAnalysisRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
