using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class RecommendationController : ControllerBase
{
    private IServiceManager _service;

    public RecommendationController(IServiceManager service) => _service = service;

    [HttpGet("professors/{professorId}/recommendations")]
    [Authorize(Roles = "Professor")]
    public IActionResult GetRecommendationsForProfessor(Guid professorId)
    {
        var recommendations = _service.Recommendation.GetRecommendationsForProfessor(professorId, false);

        return Ok(recommendations);
    }
}
