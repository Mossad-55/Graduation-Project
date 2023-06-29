namespace Shared.DataTranferObjects;

public record QuestionnaireForCreationDto(string Title, DateTime CreatedAt, DateTime EndDate, string IFrame = "");
