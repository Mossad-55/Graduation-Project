using Contracts;
using Entities.Models;

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

    public IEnumerable<Professor> GetAllProfessorsInDepartment(Guid departmentId, bool trackChanges) =>
        FindByCondition(p => p.DepartmentId == departmentId, trackChanges)
        .ToList();

    public IEnumerable<Professor> GetAllProfessorsInFaculty(Guid facultyId, bool trackChanges) =>
        FindByCondition(p => p.FacultyId == facultyId, trackChanges)
        .ToList();

    public IEnumerable<Professor> GetAllProfessorsInUniveristy(Guid universityId, bool trackChanges) =>
        FindByCondition(p => p.UniveristyId == universityId, trackChanges)
        .ToList();

    public Professor GetAProfessor(Guid id, bool trackChanges) =>
        FindByCondition(p => p.Id == id, trackChanges)
        .FirstOrDefault();
}
