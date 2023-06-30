using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Utilities;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private IAuthService _authService;

	public AuthController(IAuthService authService) => _authService = authService;

    [HttpPost("admin-login")]
    public async Task<IActionResult> LoginAdminAsync([FromBody] LoginDto model)
    {
        if (model is null)
            return BadRequest(new { message = "Object can't be null." });

        var result = await _authService.LoginAdminAsync(model, false);
        if (!result.IsAuthenticated)
            return BadRequest(new { message = "Access Denied." });
        
        if (result.Role == StaticData.UniversityAdminRole)
            return Ok(new
            {
                userId = result.UserId,
                universityId = result.UniversityId,
                email = result.Email,
                role = result.Role,
                token = result.Token
            });

        if (result.Role == StaticData.FacultyAdminRole)
            return Ok(new
            {
                userId = result.UserId,
                universityId = result.UniversityId,
                facultyId = result.FacultyId,
                email = result.Email,
                role = result.Role,
                token = result.Token
            });

        return Ok(result);
    }
}
