using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Professor
{
    public Guid Id { get; set; }
    public double Rate { get; set; }
    public string IFrame { get; set; }

    [ForeignKey(nameof(University))]
    public Guid UniveristyId { get; set; }
    public University? University { get; set; }

    [ForeignKey(nameof(Faculty))]
    public Guid FacultyId { get; set; }
    public Faculty? Faculty { get; set; }

    [ForeignKey(nameof(Department))]
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }

    public ICollection<Subject>? Subjects { get; set; }
}
