using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class FacultyAdmin
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(University))]
    public Guid UniveristyId { get; set; }
    public University? University { get; set; }

    [ForeignKey(nameof(Faculty))]
    public Guid FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
}
