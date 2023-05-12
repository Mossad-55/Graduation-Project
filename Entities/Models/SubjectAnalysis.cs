using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class SubjectAnalysis
{
    [Column("AnalysisId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime AnalysisDate { get; set; }
    [Required]
    public double AnalysisRate { get; set; }

    [ForeignKey(nameof(Subject))]
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }
}
