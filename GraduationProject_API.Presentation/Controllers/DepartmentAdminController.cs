using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/departments/{departmentId}/admins")]
public class DepartmentAdminController : ControllerBase
{
    private IServiceManager _service;

    public DepartmentAdminController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAllAdmins(Guid departmentId)
    {
        var admins = await _service.DepartmentAdminService.GetAllAdmins(departmentId, false);

        return Ok(admins);
    }

    [HttpGet("{id:Guid}", Name = "GetDepartmentAdmin")]
    public async Task<IActionResult> GetAdmin(Guid departmentId, Guid id)
    {
        var admin = await _service.DepartmentAdminService.GetDepartmentAdmin(departmentId, id, false);

        return Ok(admin);
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> UpdateAdminDetails(Guid departmentId, Guid id,
        [FromBody] UserForUpdateDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        await _service.DepartmentAdminService.UpdateAdminForDepartment(departmentId, id, admin, false);
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAdmin(Guid departmentId, [FromBody] UserForCreationDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        var result = await _service.DepartmentAdminService.CreateAdminForDepartment(departmentId, admin, false);
        return CreatedAtRoute("GetDepartmentAdmin", new { departmentId , result.Id }, result);
    }
}
