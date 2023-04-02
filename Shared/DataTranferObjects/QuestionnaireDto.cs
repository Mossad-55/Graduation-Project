namespace Shared.DataTranferObjects;

public record QuestionnaireDto(Guid Id, string Title, DateTime CreatedAt, DateTime EndDate, DateTime LastUpdatedAt);