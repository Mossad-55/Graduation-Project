using Entities.Models;
using Shared.DataTranferObjects;
using System.Linq.Expressions;

namespace Service.Contracts;

public interface IProfessorService
{
    Task<IEnumerable<ProfessorDto>> GetAllProfessorsFilter(Expression<Func<Professor, bool>> expression, bool trackChanges);
    Task<ProfessorDto> GetProfessorWithSubjects(Guid id, bool trackChanges);
    Task<ProfessorDto> CreateProfessor(Guid facultyId, Guid departmentId, UserForCreationDto professor, bool trackChanges);
    Task DeleteProfessor(Guid id, bool trackChanges);
    Task UpdateProfessor(Guid id, UserForUpdateDto professor, bool trackChanges);
}
