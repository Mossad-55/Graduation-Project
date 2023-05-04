using Entities.Models;
using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IStudentService
{
    Task<StudentDto> GetStudentWithSubjects(Guid id, bool trackChanges);
}
