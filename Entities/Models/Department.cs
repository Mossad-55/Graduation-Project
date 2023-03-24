using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Department
{
    [Column("DepartmentId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Department name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Description is a required field.")]
    public string? Description { get; set; }
    public double Rate { get; set; }

    [ForeignKey(nameof(Faculty))]
    public Guid FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
}
