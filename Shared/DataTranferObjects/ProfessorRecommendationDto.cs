namespace Shared.DataTranferObjects;

public record ProfessorRecommendationDto
{
    public string? SubjectName { get; init; }
    public RecommendationDto? Recommendation { get; init; }
}
