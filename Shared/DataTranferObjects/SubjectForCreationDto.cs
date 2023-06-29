namespace Shared.DataTranferObjects;

public record SubjectForCreationDto(string Name, string Code, string Description, Guid ProfessorId, string IFrame = "");
