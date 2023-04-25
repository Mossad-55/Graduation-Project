namespace Shared.DataTranferObjects;

public record SubjectForUpdateDto(string Name, string Code, string Description, Guid ProfessorId);
