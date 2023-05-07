using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Submition
{
    [Column("SubmitionId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime SubmitionDate { get; set; }
    [Required]
    public int InstructorEfficiency { get; set; }
    [Required]
    public int CourseUnderstand { get; set; }
    [Required]
    public int InstructorRespect { get; set; }
    [Required]
    public int InstructorMaterial { get; set; }
    [Required]
    public int ExamContent { get; set; }
    [Required]
    public int AssistantTeacher { get; set; }
    [Required]
    public int InstructorRecommendation { get; set; }
    [Required]
    public int CourseRecommendation { get; set; }
    [Required]
    public int CourseMarket { get; set; }

    [ForeignKey(nameof(Questionnaire))]
    public Guid QuestionnaireId { get; set; }
    public Questionnaire? Questionnaire { get; set; }

    [ForeignKey(nameof(Student))]
    public Guid StudentId { get; set;}
    public Student? Student { get; set; }
}
