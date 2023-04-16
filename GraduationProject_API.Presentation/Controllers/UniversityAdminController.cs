using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/universities/{universityId}/admins")]
public class UniversityAdminController : ControllerBase
{
    private readonly IServiceManager _service;
    public UniversityAdminController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAllAdmins(Guid universityId)
    {
        var admins = await _service.UniversityAdminService.GetAllAdmins(universityId, false);

        return Ok(admins);
    }

    [HttpGet("{id:Guid}", Name = "GetUniversityAdmin")]
    public async Task<IActionResult> GetAdmin(Guid universityId, Guid id)
    {
        var admin = await _service.UniversityAdminService.GetUniveristyAdmin(universityId, id, false);
        
        return Ok(admin);
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> UpdateAdminDetails(Guid universityId, Guid id, 
        [FromBody] AdminForUpdateDto admin)
    {
        if (admin is null)
            return BadRequest("Object is null");

        await _service.UniversityAdminService.UpdateAdminForUniversity(universityId, id, admin, false, true);
        return NoContent();
    }
}
