using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class University
{
    [Column]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "University name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the University name is 60 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "University description is a required field.")]
    public string? Description { get; set; }

    public double Rate { get; set; }
    
    public ICollection<Faculty>? Faculties { get; set; }
}
