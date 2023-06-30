using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class SubmitionController : ControllerBase
{
    private readonly IServiceManager _service;

	public SubmitionController(IServiceManager service) => _service = service;

    [HttpGet("questionnaires/{questionnaireId}/students/{studentId}/check")]
    public IActionResult CheckStudentSubmition(Guid questionnaireId, Guid studentId)
    {
        var result = _service.SubmitionService.CheckStudentSubmition(questionnaireId, studentId, false);
        if (!result)
            return Ok(new {message = "Please answer the following questions."});

        return BadRequest(new {message = "You had already submitted the questionnaire."});
    }
}
