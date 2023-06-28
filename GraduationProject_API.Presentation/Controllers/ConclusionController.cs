using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class ConclusionController : ControllerBase
{
    private IServiceManager _service;

    public ConclusionController(IServiceManager service) => _service = service;

    [HttpGet("subjects/{subjectId}/conclusion")]
    public IActionResult GetConclusionForSubject(Guid subjectId)
    {
        var conclusion = _service.SubjectConclusion.GetLatestConclusionForSubject(subjectId, false);

        return Ok(conclusion);
    }

    [HttpGet("questionnaires/{questionnaireId}/conclusion")]
    public IActionResult GetConclusionForQuestionnaire(Guid questionnaireId)
    {
        var conclusion = _service.SubjectConclusion.GetConclusionForQuestionnaire(questionnaireId, false);

        return Ok(conclusion);
    }
}
