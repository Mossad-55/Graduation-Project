using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/universities/{universityId}/faculities")]
public class FaculitiesController : ControllerBase
{
    private readonly IServiceManager _service;
    
    public FaculitiesController(IServiceManager service) => _service = service;

    [HttpGet]
    [Authorize(Roles = "University Admin")]
    public IActionResult GetFaculitiesForUniversity(Guid universityId)
    {
        var faculities = _service.FacultyService.GetAllFaculities(universityId, trackChanges: false);

        return Ok(faculities);
    }

    [HttpGet("{id:Guid}", Name = "GetFacultyForUniversity")]
    [Authorize(Roles = "University Admin, Faculty Admin")]
    public IActionResult GetFaculty(Guid universityId, Guid id)
    {
        var faculty = _service.FacultyService.GetFaculty(universityId, id, trackChanges: false);

        return Ok(faculty);
    }

    [HttpPost]
    [Authorize(Roles = "University Admin")]
    public IActionResult CreateFaculty(Guid universityId, [FromBody] FacultyForCreationDto faculty)
    {
        if (faculty is null)
            return BadRequest("Object in null");

        var facultyToReturn = _service.FacultyService.CreateFacultyForUniversity(universityId, faculty, trackChanges: false);

        return CreatedAtRoute("GetFacultyForUniversity", new { universityId, id = facultyToReturn.Id }, facultyToReturn);
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "University Admin")]
    public IActionResult DeleteFacultyForUniversity(Guid universityId, Guid id)
    {
        _service.FacultyService.DeleteFacultyForUniversity(universityId, id, trackChanges: false);

        return NoContent();
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "University Admin")]
    public IActionResult UpdateFacultyForUniversity(Guid universityId, Guid id,
        [FromBody] FacultyForUpdateDto faculty)
    {
        if (faculty is null)
            return BadRequest("Object is null");

        _service.FacultyService.UpdateFacultyForUniversity(universityId, id, faculty, false, true);
        return NoContent();
    }
}
