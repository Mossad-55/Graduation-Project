using Entities.Models;
using System.Linq.Expressions;

namespace Contracts;

public interface IProfessorRepository
{
    IEnumerable<Professor> GetAllProfessorsFilter(Expression<Func<Professor, bool>> expression, bool trackChanges);
    Professor GetAProfessor(Guid id, bool trackChanges);
    void CreateProfessor(Guid universityId, Guid facultyId, Guid departmentId, Professor professor);
    void DeleteProfessor(Professor professor);
}
