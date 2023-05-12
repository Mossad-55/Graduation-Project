using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class FacultyAnalysis
{
    [Column("AnalysisId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime AnalysisDate { get; set; }
    [Required]
    public double AnalysisRate { get; set; }

    [ForeignKey(nameof(Faculty))]
    public Guid FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
}
