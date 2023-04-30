using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class ProfessorsController : ControllerBase
{
    private readonly IServiceManager _service;

	public ProfessorsController(IServiceManager service) => _service = service;

    [HttpGet("universities/{universityId}/professors")]
    public async Task<IActionResult> GetProfessorsInUniversity(Guid universityId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.UniveristyId == universityId, false);

        return Ok(professors);
    }

    [HttpGet("faculities/{facultyId}/professors")]
    public async Task<IActionResult> GetProfessorsInFaculty(Guid facultyId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.FacultyId == facultyId, false);

        return Ok(professors);
    }

    [HttpGet("departments/{departmentId}/professors")]
    public async Task<IActionResult> GetProfessorsInDepartment(Guid departmentId)
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.DepartmentId== departmentId, false);

        return Ok(professors);
    }

    [HttpGet("professors/{id:Guid}", Name = "GetProfessor")]
    public async Task<IActionResult> GetAProfessorById(Guid id)
    {
        var professor = await _service.ProfessorService.GetProfessor(id, false);

        return Ok(professor);
    }

    [HttpPost("faculities/{facultyId}/departments/{departmentId}/professors")]
    public async Task<IActionResult> CreateProfessor(Guid facultyId, Guid departmentId, [FromBody] UserForCreationDto user)
    {
        if (user is null)
            return BadRequest("Object is null");

        var professor = await _service.ProfessorService.CreateProfessor(facultyId, departmentId, user, false);

        return CreatedAtRoute("GetProfessor", new { professor.Id }, professor);
    }

    [HttpDelete("professors/{id:Guid}")]
    public async Task<IActionResult> DeleteProfessor(Guid id)
    {
        await _service.ProfessorService.DeleteProfessor(id, false);

        return NoContent();
    }

    [HttpPut("professors/{id:Guid}")]
    public async Task<IActionResult> UpdateProfessor(Guid id, [FromBody] UserForUpdateDto user)
    {
        if (user is null)
            return BadRequest("Object is null");

        await _service.ProfessorService.UpdateProfessor(id, user, true);

        return NoContent();
    }
}
