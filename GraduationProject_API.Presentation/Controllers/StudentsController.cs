﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    private readonly IServiceManager _service;

    public StudentsController(IServiceManager service) => _service = service;

    [HttpGet("{id:Guid}")]
    [Authorize(Roles = "Student")]
    public async Task<IActionResult> GetStudentWithSubject(Guid id)
    {
        var student = await _service.StudentService.GetStudentWithSubjects(id, false);

        return Ok(student);
    }

    [HttpGet("{id:Guid}/subjects")]
    [Authorize(Roles = "Student")]
    public async Task<IActionResult> GetStudentSubjectsAndQestionnaire(Guid id)
    {
        var subjects = await _service.StudentService.GetStudentSubjectsWithQuestionnaires(id, false);

        return Ok(subjects);
    }

    [HttpPost("{id:Guid}/questionnaire/{questionnaireId}/submit")]
    [Authorize(Roles = "Student")]
    public IActionResult SubmitionForQuestionnaire(Guid id, Guid questionnaireId, [FromBody] SubmitionForCreationDto submition)
    {
        _service.SubmitionService.AddSubmition(questionnaireId, id, submition, false);
        
        return NoContent();
    }
}
