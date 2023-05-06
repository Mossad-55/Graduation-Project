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
    public int InstEffic { get; set; }
    [Required]
    public int CourseUnderstand { get; set; }
    [Required]
    public int IntRespect { get; set; }
    [Required]
    public int InstMaterial { get; set; }
    [Required]
    public int ExamContent { get; set; }
    [Required]
    public int AssisTeacher { get; set; }
    [Required]
    public int InstRecommend { get; set; }
    [Required]
    public int CourseRecommend { get; set; }
    [Required]
    public int CourseMarket { get; set; }

    [ForeignKey(nameof(Questionnaire))]
    public Guid QuestionnaireId { get; set; }
    public Questionnaire? Questionnaire { get; set; }

    [ForeignKey(nameof(Student))]
    public Guid StudentId { get; set;}
    public Student? Student { get; set; }
}
