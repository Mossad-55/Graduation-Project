using Contracts;
using Entities.Models;

namespace Repository;

internal sealed class DepartmentAnalysisRepository : RepositoryBase<DepartmentAnalysis>, IDepartmentAnalysisRepository
{
    public DepartmentAnalysisRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
