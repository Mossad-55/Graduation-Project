using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Faculty
{
    [Column("FacultyId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Faculty name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Description is a required field.")]
    public string? Description { get; set; }
    public double Rate { get; set; }

    [ForeignKey(nameof(University))]
    public Guid UniversityId { get; set; }
    public University? University { get; set; }
    public ICollection<Department>? Departments { get; set; }
}
