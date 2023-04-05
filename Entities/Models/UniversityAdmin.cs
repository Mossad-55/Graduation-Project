using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class UniversityAdmin
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }

    [ForeignKey(nameof(University))]
    public Guid UniversityId { get; set; }
    public University? University { get; set; }
}
