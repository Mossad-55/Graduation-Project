using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/departments/{departmentId}/subjects/{subjectId}/questionnaires")]
public class QuestionnaireController : ControllerBase
{
    private readonly IServiceManager _service;

    public QuestionnaireController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetQuestionnairesForSubject(Guid departmentId, Guid subjectId)
    {
        var questionnaires = _service.QuestionnaireService.GetAllQuestionnaires(departmentId, subjectId, false);

        return Ok(questionnaires);
    }

    [HttpGet("{id:Guid}", Name = "GetQuestionnaireForSubject")]
    public IActionResult GetQuestionnaire(Guid departmentId, Guid subjectId, Guid id)
    {
        var questionnaire = _service.QuestionnaireService.GetQuestionnaire(departmentId, subjectId, id, false);

        return Ok(questionnaire);
    }

    [HttpPost]
    public IActionResult CreateQuestionnaire(Guid departmentId, Guid subjectId, [FromBody] QuestionnaireForCreationDto questionnaire)
    {
        if (questionnaire is null)
            return BadRequest("Object is null");

        var questionnaireToReturn = _service.QuestionnaireService.CreateQuestionnaireForSubject(departmentId, subjectId, questionnaire, false);

        return CreatedAtRoute("GetQuestionnaireForSubject", new { departmentId, subjectId, id = questionnaireToReturn.Id }, questionnaireToReturn);
    }

    [HttpDelete("{id:Guid}")]
    public IActionResult DeleteQuestionnaire(Guid departmentId, Guid subjectId, Guid id)
    {
        _service.QuestionnaireService.DeleteQuestionnaireForSubject(departmentId, subjectId, id, false);

        return NoContent();
    }

    [HttpPut("{id:Guid}")]
    public IActionResult UpdateQuestionnaire(Guid departmentId, Guid subjectId, Guid id, 
        [FromBody]QuestionnaireForUpdateDto questionnaire)
    {
        if (questionnaire is null)
            return BadRequest("Object is null");

        _service.QuestionnaireService.UpdateQuestionnaireForSubject(departmentId, subjectId, id, questionnaire, false, true);

        return NoContent();
    }
}
