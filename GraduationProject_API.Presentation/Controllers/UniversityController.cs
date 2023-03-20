using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

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

    [HttpGet("{id:guid}")]
    public IActionResult GetUniversity(Guid id)
    {
        var university = _service.UniversityService.GetUniversity(id, trackChanges: false);

        return Ok(university);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateUniversity(Guid id, [FromBody]UniversityForUpdateDto university)
    {
        if (university is null)
            return BadRequest("University Object is null!");

        _service.UniversityService.UpdateUniversity(id, university, trackChanges: true);

        return NoContent();
    }
}
