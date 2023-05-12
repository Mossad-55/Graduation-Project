using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class FacultyAnalysisRepository : RepositoryBase<FacultyAnalysis>, IFacultyAnalysisRepository
{
    public FacultyAnalysisRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
