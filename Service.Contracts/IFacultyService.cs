using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IFacultyService
{
    IEnumerable<FacultyDto> GetAllFaculities(Guid universityId, bool trackChanges);
    FacultyDto GetFaculty(Guid universityId, Guid id, bool trackChanges);
    FacultyDto CreateFacultyForUniversity(Guid universityId, FacultyForCreationDto faculty, bool trackChanges);
    void DeleteFacultyForUniversity(Guid universityId, Guid id, bool trackChanges);
    void UpdateFacultyForUniversity(Guid universityId, Guid id, FacultyForUpdateDto faculty, bool uniTrackChanges, bool facTrackChanges);
}
