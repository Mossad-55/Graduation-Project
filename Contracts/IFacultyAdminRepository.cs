using Entities.Models;

namespace Contracts;

public interface IFacultyAdminRepository
{
    IEnumerable<FacultyAdmin> GetAllFacultyAdmins(Guid facultyId, bool trackChanges);
    FacultyAdmin GetFacultyAdmin(Guid facultyId, Guid id, bool trackChanges);
    void CreateFacultyAdmin(Guid universityId, Guid facultyId, FacultyAdmin facultyAdmin);
    void DeleteFacultyAdmin(FacultyAdmin facultyAdmin);
}
