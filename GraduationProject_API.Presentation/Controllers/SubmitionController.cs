using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class SubmitionController : ControllerBase
{
    private readonly IServiceManager _service;

	public SubmitionController(IServiceManager service) => _service = service;

    [HttpGet("questionnaires/{questionnaireId}/submitions")]
    public IActionResult GetSubmitionsForQuestionnaire(Guid questionnaireId)
    {

        // لازم اضيف العمود الزيادة في الكوستشنير و لما زيدان يطلب مني اخليه ب ترو
        var submitions = _service.SubmitionService.GetSubmitionsForQuestionnaire(questionnaireId, false);

        return Ok(submitions);
    }

    [HttpGet("questionnaires/{questionnaireId}/students/{studentId}/check")]
    public IActionResult CheckStudentSubmition(Guid questionnaireId, Guid studentId)
    {
        var result = _service.SubmitionService.CheckStudentSubmition(questionnaireId, studentId, false);
        if (result)
            return Ok(new {message = "Student can submit"});

        return BadRequest(new {message = "Student has already submitted the questionnaire"});
    }
}
