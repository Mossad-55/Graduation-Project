using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class FacultyAdmin
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }

    [ForeignKey(nameof(Faculty))]
    public Guid FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
}
