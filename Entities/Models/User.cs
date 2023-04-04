using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [ForeignKey(nameof(University))]
    public Guid UniversityId { get; set; }
    public University? University { get; set; }
}
