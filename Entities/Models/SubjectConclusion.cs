using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class SubjectConclusion
{
    [Column("SubjectConclusionId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string? GoodConclusion { get; set; }
    [Required]
    public string? BadConclusion { get; set; }


    [ForeignKey(nameof(Subject))]
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    [ForeignKey(nameof(Questionnaire))]
    public Guid QuestionnaireId { get; set; }
    public Questionnaire? Questionnaire { get; set; }
}
