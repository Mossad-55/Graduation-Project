using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;
using System.ComponentModel.DataAnnotations;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    private readonly IServiceManager _service;

    public StudentsController(IServiceManager service) => _service = service;

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetStudentWithSubject(Guid id)
    {
        var student = await _service.StudentService.GetStudentWithSubjects(id, false);

        return Ok(student);
    }

    [HttpGet("{id:Guid}/subjects")]
    public async Task<IActionResult> GetStudentSubjectsAndQestionnaire(Guid id)
    {
        var subjects = await _service.StudentService.GetStudentSubjectsWithQuestionnaires(id, false);

        return Ok(subjects);
    }

    [HttpPost("{id:Guid}/questionnaire/{questionnaireId}/submit")]
    public IActionResult SubmitionForQuestionnaire(Guid id, Guid questionnaireId, [FromBody] SubmitionForCreationDto submition)
    {
        _service.SubmitionService.AddSubmition(questionnaireId, id, submition, false);
        
        return NoContent();
    }

    [HttpGet("questionnaire/{questionnaireId}")]
    public IActionResult GetSubmition(Guid questionnaireId)
    {
        var submitions = _service.SubmitionService.GetSubmitionsForQuestionnaire(questionnaireId, false);

        return Ok(submitions);
    }
}
