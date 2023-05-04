using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository;

internal sealed class ProfessorRepository : RepositoryBase<Professor>, IProfessorRepository
{
    public ProfessorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateProfessor(Guid universityId, Guid facultyId, Guid departmentId, Professor professor)
    {
        professor.UniveristyId = universityId;
        professor.FacultyId = facultyId;
        professor.DepartmentId = departmentId;
        Create(professor);
    }

    public void DeleteProfessor(Professor professor) => Delete(professor);

    public IEnumerable<Professor> GetAllProfessorsFilter(Expression<Func<Professor, bool>> expression, bool trackChanges) =>
        FindByCondition(expression, trackChanges)
        .ToList();

    public Professor GetAProfessor(Guid id, bool trackChanges) =>
        FindByCondition(p => p.Id == id, trackChanges)
        .FirstOrDefault();

    public Professor GetAProfessorWithSubjects(Guid id, bool trackChanges) =>
        FindByCondition(p => p.Id == id, trackChanges)
        .Include(p => p.Subjects)
            .ThenInclude(x => x.Questionnaires)
        .FirstOrDefault();
}
