using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/faculities/{facultyId}/departments/{departmentId}/admins")]
public class DepartmentAdminController : ControllerBase
{
    private IServiceManager _service;

    public DepartmentAdminController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAllAdmins(Guid facultyId, Guid departmentId)
    {
        var admins = await _service.DepartmentAdminService.GetAllAdmins(facultyId, departmentId, false);

        return Ok(admins);
    }

    [HttpGet("{id:Guid}", Name = "GetDepartmentAdmin")]
    public async Task<IActionResult> GetAdmin(Guid facultyId, Guid departmentId, Guid id)
    {
        var admin = await _service.DepartmentAdminService.GetDepartmentAdmin(facultyId, departmentId, id, false);

        return Ok(admin);
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> UpdateAdminDetails(Guid facultyId, Guid departmentId, Guid id,
        [FromBody] AdminForUpdateDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        await _service.DepartmentAdminService.UpdateAdminForDepartment(facultyId, departmentId, id, admin, false);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAdmin(Guid facultyId, Guid departmentId, [FromBody] AdminForCreationDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        var result = await _service.DepartmentAdminService.CreateAdminForDepartment(facultyId, departmentId, admin, false);
        return CreatedAtRoute("GetDepartmentAdmin", new { facultyId, departmentId , result.Id }, result);
    }
}
