namespace Shared.DataTranferObjects;

public record SubmitionDto
{
    public Guid Id { get; init; }
    public int InstructorEfficiency { get; init; }
    public int CourseUnderstand { get; init; }
    public int InstructorRespect { get; init; }
    public int InstructorMaterial { get; init; }
    public int ExamContent { get; init; }
    public int AssistantTeacher { get; init; }
    public int InstructorRecommendation { get; init; }
    public int CourseRecommendation { get; init; }
    public int CourseMarket { get; init; }
}