using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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

    /*[HttpGet("faculities/{facultyId}/professors")]
    public async Task<IActionResult> GetProfessorsInFaculty(Guid universityId, )
    {
        var professors = await _service.ProfessorService.GetAllProfessorsFilter(x => x.UniveristyId == universityId, false);

        return Ok(professors);
    }*/
}
