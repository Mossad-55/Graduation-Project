namespace Contracts;

public interface IRepositoryManager
{
    // All IRepository Interfaces.
    IUniversityRepository University { get; }
    IFacultyRepository Faculty { get; }
    IDepartmentRepository Department { get; }
    ISubjectRepository Subject { get; }
    IQuestionnaireRepository Questionnaire { get; }
    IUniversityAdminRepository UniversityAdmin { get; }
    IFacultyAdminRepository FacultyAdmin { get; }
    IDepartmentAdminRepository DepartmentAdmin { get; }
    IProfessorRepository Professor { get; }
    IStudentRepository Student { get; }
    ISubmitionRepository Submition { get; }

    // Shared Functions.
    void Save();
}
