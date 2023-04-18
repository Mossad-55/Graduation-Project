namespace Service.Contracts;

public interface IServiceManager
{
    // All the IServices Interfaces.
    IUniversityService UniversityService { get; }
    IFacultyService FacultyService { get; }
    IDepartmentService DepartmentService { get; }
    ISubjectService SubjectService { get; }
    IQuestionnaireService QuestionnaireService { get; }
    IUniversityAdminService UniversityAdminService { get; }
    IFacultyAdminService FacultyAdminService { get; }
    IDepartmentAdminService DepartmentAdminService { get; }

}
