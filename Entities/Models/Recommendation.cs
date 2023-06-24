using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Recommendation
{
    [Column("RecommendationId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string? Content { get; set; }


    [ForeignKey(nameof(Subject))]
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    [ForeignKey(nameof(Professor))]
    public Guid ProfessorId { get; set; }
    public Professor? Professor { get; set; }
}
