using Entities.Models;

namespace Contracts;

public interface IProfessorRepository
{
    IEnumerable<Professor> GetAllProfessorsInUniveristy(Guid universityId, bool trackChanges);
    IEnumerable<Professor> GetAllProfessorsInFaculty(Guid facultyId, bool trackChanges);
    IEnumerable<Professor> GetAllProfessorsInDepartment(Guid departmentId, bool trackChanges);
    Professor GetAProfessor(Guid id, bool trackChanges);
    void CreateProfessor(Guid universityId, Guid facultyId, Guid departmentId, Professor professor);
    void DeleteProfessor(Professor professor);
}
