using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;
using System.Data;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class ProfessorsController : ControllerBase
{
    private readonly IServiceManager _service;

	public ProfessorsController(IServiceManager service) => _service = service;

    [HttpGet("universities/{universityId}/professors")]
    [Authorize(Roles = "University Admin")]
    public async Task<IActionResult> GetProfessorsInUniversity(Guid universityId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.UniveristyId == universityId, false);

        return Ok(professors);
    }

    [HttpGet("faculities/{facultyId}/professors")]
    [Authorize(Roles = "University Admin, Faculty Admin")]
    public async Task<IActionResult> GetProfessorsInFaculty(Guid facultyId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.FacultyId == facultyId, false);

        return Ok(professors);
    }

    [HttpGet("departments/{departmentId}/professors")]
    [Authorize(Roles = "University Admin, Faculty Admin, Department Admin")]
    public async Task<IActionResult> GetProfessorsInDepartment(Guid departmentId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.DepartmentId== departmentId, false);

        return Ok(professors);
    }

    [HttpGet("professors/{id:Guid}", Name = "GetProfessor")]
    [Authorize(Roles = "University Admin, Faculty Admin, Department Admin, Professor")]
    public async Task<IActionResult> GetAProfessorById(Guid id)
    {
        var professor = await _service.ProfessorService.GetProfessorWithSubjects(id, false);

        return Ok(professor);
    }

    [HttpPost("faculities/{facultyId}/departments/{departmentId}/professors")]
    [Authorize(Roles = "Faculty Admin")]
    public async Task<IActionResult> CreateProfessor(Guid facultyId, Guid departmentId, [FromBody] UserForCreationDto user)
    {
        if (user is null)
            return BadRequest("Object is null");

        var professor = await _service.ProfessorService.CreateProfessor(facultyId, departmentId, user, false);

        return CreatedAtRoute("GetProfessor", new { professor.Id }, professor);
    }

    [HttpDelete("professors/{id:Guid}")]
    [Authorize(Roles = "Faculty Admin")]
    public async Task<IActionResult> DeleteProfessor(Guid id)
    {
        await _service.ProfessorService.DeleteProfessor(id, false);

        return NoContent();
    }

    [HttpPut("professors/{id:Guid}")]
    [Authorize(Roles = "Faculty Admin")]
    public async Task<IActionResult> UpdateProfessor(Guid id, [FromBody] UserForUpdateDto user)
    {
        if (user is null)
            return BadRequest("Object is null");

        await _service.ProfessorService.UpdateProfessor(id, user, true);

        return NoContent();
    }
}
