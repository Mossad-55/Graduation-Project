using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/faculities/{facultyId}/admins")]
public class FacultyAdminsController : ControllerBase
{
    private IServiceManager _service;

    public FacultyAdminsController(IServiceManager service) => _service = service;

    [HttpGet]
    [Authorize(Roles = "University Admin")]
    public async Task<IActionResult> GetAllAdmins(Guid facultyId)
    {
        var admins = await _service.FacultyAdminService.GetAllAdmins(facultyId, false);

        return Ok(admins);
    }

    [HttpGet("{id:Guid}", Name = "GetFacultyAdmin")]
    [Authorize(Roles = "University Admin, Faculty Admin")]
    public async Task<IActionResult> GetAdmin(Guid facultyId, Guid id)
    {
        var admin = await _service.FacultyAdminService.GetFacultyAdmin(facultyId, id, false);

        return Ok(admin);
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "University Admin")]
    public async Task<IActionResult> UpdateAdminDetails(Guid facultyId, Guid id,
        [FromBody] UserForUpdateDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        await _service.FacultyAdminService.UpdateAdminForFaculty(facultyId, id, admin, false);
        return NoContent();
    }

    [HttpPost]
    [Authorize(Roles = "University Admin")]
    public async Task<IActionResult> CreateAdmin(Guid facultyId, [FromBody] UserForCreationDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        var result = await _service.FacultyAdminService.CreateAdminForFaculty(facultyId, admin, false);
        return CreatedAtRoute("GetFacultyAdmin", new { facultyId, result.Id }, result);
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "University Admin")]
    public async Task<IActionResult> DeleteAdmin(Guid facultyId, Guid id)
    {
        await _service.FacultyAdminService.DeleteAdminForFaculty(facultyId, id, false);

       return NoContent();
    }
}
