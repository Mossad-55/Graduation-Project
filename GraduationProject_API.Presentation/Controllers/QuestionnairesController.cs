using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api")]
public class QuestionnairesController : ControllerBase
{
    private readonly IServiceManager _service;

    public QuestionnairesController(IServiceManager service) => _service = service;

    [HttpGet("questionnaires/{id:Guid}")]
    public IActionResult GetQuestionnaireById(Guid id)
    {
        var questionnaire = _service.QuestionnaireService.GetQuestionnaireById(id, false);

        return Ok(questionnaire);
    }

    [HttpGet("departments/{departmentId}/subjects/{subjectId}/questionnaires")]
    public IActionResult GetQuestionnairesForSubject(Guid departmentId, Guid subjectId)
    {
        var questionnaires = _service.QuestionnaireService.GetAllQuestionnaires(departmentId, subjectId, false);

        return Ok(questionnaires);
    }

    [HttpGet("/departments/{departmentId}/subjects/{subjectId}/questionnaires/{id:Guid}", Name = "GetQuestionnaireForSubject")]
    public IActionResult GetQuestionnaire(Guid departmentId, Guid subjectId, Guid id)
    {
        var questionnaire = _service.QuestionnaireService.GetQuestionnaire(departmentId, subjectId, id, false);

        return Ok(questionnaire);
    }

    [HttpPost("departments/{departmentId}/subjects/{subjectId}/questionnaires")]
    public IActionResult CreateQuestionnaire(Guid departmentId, Guid subjectId, [FromBody] QuestionnaireForCreationDto questionnaire)
    {
        if (questionnaire is null)
            return BadRequest("Object is null");

        var questionnaireToReturn = _service.QuestionnaireService.CreateQuestionnaireForSubject(departmentId, subjectId, questionnaire, false);

        return CreatedAtRoute("GetQuestionnaireForSubject", new { departmentId, subjectId, id = questionnaireToReturn.Id }, questionnaireToReturn);
    }

    [HttpDelete("departments/{departmentId}/subjects/{subjectId}/questionnaires/{id:Guid}")]
    public IActionResult DeleteQuestionnaire(Guid departmentId, Guid subjectId, Guid id)
    {
        _service.QuestionnaireService.DeleteQuestionnaireForSubject(departmentId, subjectId, id, false);

        return NoContent();
    }

    [HttpPut("departments/{departmentId}/subjects/{subjectId}/questionnaires/{id:Guid}")]
    public IActionResult UpdateQuestionnaire(Guid departmentId, Guid subjectId, Guid id, 
        [FromBody]QuestionnaireForUpdateDto questionnaire)
    {
        if (questionnaire is null)
            return BadRequest("Object is null");

        _service.QuestionnaireService.UpdateQuestionnaireForSubject(departmentId, subjectId, id, questionnaire, false, true);

        return NoContent();
    }
}
