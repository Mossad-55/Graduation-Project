using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/faculities/{facultyId}/departments/{departmentId}/subjects")]
public class SubjectsController : ControllerBase
{
    private readonly IServiceManager _service;

	public SubjectsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetSubjectsForDepartment(Guid facultyId, Guid departmentId)
    {
        var subjects = _service.SubjectService.GetAllSubjects(facultyId, departmentId ,false);

        return Ok(subjects);
    }

    [HttpGet("{id:Guid}", Name = "GetSubjectForDepartment")]
    public IActionResult GetSubject(Guid facultyId, Guid departmentId, Guid id)
    {
        var subject = _service.SubjectService.GetSubject(facultyId, departmentId, id, false);

        return Ok(subject);
    }

    [HttpPost]
    public IActionResult CreateSubject(Guid facultyId, Guid departmentId, [FromBody] SubjectForCreationDto subject)
    {
        if (subject is null)
            return BadRequest("Object is null");

        var subjectToReturn = _service.SubjectService.CreateSubjectForDepartment(facultyId, departmentId, subject, false);

        return CreatedAtRoute("GetSubjectForDepartment", new { facultyId, departmentId, id = subjectToReturn.Id }, subjectToReturn);
    }

    [HttpDelete("{id:Guid}")]
    public IActionResult DeleteSubject(Guid facultyId, Guid departmentId, Guid id)
    {
        _service.SubjectService.DeleteSubjectForDepartment(facultyId, departmentId, id, false);

        return NoContent();
    }

    [HttpPut("{id:Guid}")]
    public IActionResult UpdateSubject(Guid facultyId, Guid departmentId, Guid id,
        [FromBody] SubjectForUpdateDto subject)
    {
        if (subject is null)
            return BadRequest("Object is null");

        _service.SubjectService.UpdateSubjectForDepartment(facultyId, departmentId, id, subject, false, true);

        return NoContent();
    }
}
