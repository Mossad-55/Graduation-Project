using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace GraduationProject_API.Presentation.Controllers;

[Route("api/universities")]
[ApiController]
public class UniversityController : ControllerBase
{
    private readonly IServiceManager _service;

    public UniversityController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetUniversities()
    {
        var universities = _service.UniversityService.GetAllUniversities(trackChanges: false);
        return Ok(universities);
    }
    
}
