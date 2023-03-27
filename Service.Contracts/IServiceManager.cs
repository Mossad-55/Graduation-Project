namespace Service.Contracts;

public interface IServiceManager
{
    // All the IServices Interfaces.
    IUniversityService UniversityService { get; }
    IFacultyService FacultyService { get; }
    IDepartmentService DepartmentService { get; }
    ISubjectService SubjectService { get; }

}
