namespace Shared.DataTranferObjects;

public record RecommendationDto(string SubjectName, string Date, IEnumerable<string> Content);
