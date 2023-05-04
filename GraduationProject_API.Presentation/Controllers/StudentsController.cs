﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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
}
