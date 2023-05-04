using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

internal sealed class StudentRepository : RepositoryBase<Student>, IStudentRepository
{
    public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public Student GetStudentWithSubjects(Guid id, bool trackChanges) =>
        FindByCondition(s => s.Id == id, trackChanges)
        .Include(s => s.Subjects)
        .FirstOrDefault();
}
