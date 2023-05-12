using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class DepartmentAnalysis
{
    [Column("AnalysisId")]
    public Guid Id { get; set; }
    [Required]
    public DateTime AnalysisDate { get; set; }
    [Required]
    public double AnalysisRate { get; set; }

    [ForeignKey(nameof(Department))]
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
}
