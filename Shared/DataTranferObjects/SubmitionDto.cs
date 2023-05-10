namespace Shared.DataTranferObjects;

public record SubmitionDto(Guid Id, int InstructorEfficiency, int CourseUnderstand, int InstructorRespect
    , int InstructorMaterial, int ExamContent, int AssistantTeacher, int InstructorRecommendation
    , int CourseRecommendation, int CourseMarket);
