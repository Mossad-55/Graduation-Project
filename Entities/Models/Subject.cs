using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Subject
{
    [Column("SubjectId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Subject name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Subject code field is a required field.")]
    public string? Code { get; set; }

    [Required(ErrorMessage = "Description is a required field.")]
    public string? Description { get; set; }
    public double Rate { get; set; }
    public string IFrame { get; set; }


    [ForeignKey(nameof(Department))]
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }

    [ForeignKey(nameof(Professor))]
    public Guid ProfessorId { get; set; }
    public Professor? Professor { get; set; }

    public ICollection<Student>? Students { get; set; }
    public ICollection<Questionnaire>? Questionnaires { get; set; }
}
