using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Questionnaire
{
    [Column("QuestionnaireId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Questionanaire title is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the title is 60 characters.")]
    public string? Title { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }

    [ForeignKey(nameof(Subject))]
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }
}
