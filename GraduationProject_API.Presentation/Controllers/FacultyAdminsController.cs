using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/universities/{universityId}/faculities/{facultyId}/admins")]
public class FacultyAdminsController : ControllerBase
{
    private IServiceManager _service;

    public FacultyAdminsController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAllAdmins(Guid universityId, Guid facultyId)
    {
        var admins = await _service.FacultyAdminService.GetAllAdmins(universityId, facultyId, false);

        return Ok(admins);
    }

    [HttpGet("{id:Guid}", Name = "GetFacultyAdmin")]
    public async Task<IActionResult> GetAdmin(Guid universityId, Guid facultyId, Guid id)
    {
        var admin = await _service.FacultyAdminService.GetFacultyAdmin(universityId, facultyId, id, false);

        return Ok(admin);
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> UpdateAdminDetails(Guid universityId, Guid facultyId, Guid id,
        [FromBody] AdminForUpdateDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        await _service.FacultyAdminService.UpdateAdminForFaculty(universityId, facultyId, id, admin, false, true);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAdmin(Guid universityId, Guid facultyId, [FromBody] AdminForCreationDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        var result = await _service.FacultyAdminService.CreateAdminForFaculty(universityId, facultyId, admin, false);
        return CreatedAtRoute("GetFacultyAdmin", new { universityId, facultyId, result.Id }, result);
    }
}
