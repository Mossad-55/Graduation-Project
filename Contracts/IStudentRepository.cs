using Entities.Models;

namespace Contracts;

public interface IStudentRepository
{
    Student GetStudentWithSubjects(Guid id, bool trackChanges);
    Student GetStudentById(Guid id, bool trackChanges);
    bool CheckForStudentById(Guid id, bool trackChanges);
}