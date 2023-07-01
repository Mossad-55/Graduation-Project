using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;
using System.Data;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/universities/{universityId}/faculities/{facultyId}/departments")]
public class DepartmentsController : ControllerBase
{
    private readonly IServiceManager _service;

    public DepartmentsController(IServiceManager service) => _service = service;

    [HttpGet]
    [Authorize(Roles = "University Admin, Faculty Admin")]
    public IActionResult GetDepartmentsForFaculty(Guid universityId, Guid facultyId)
    {
        var departments = _service.DepartmentService.GetAllDepartments(universityId, facultyId, false);

        return Ok(departments);
    }

    [HttpGet("low-rate")]
    [Authorize(Roles = "Faculty Admin, Department Admin")]
    public IActionResult GetDepartmentsWithLowRate(Guid universityId, Guid facultyId)
    {
        var departmentsWithSubjects = _service.DepartmentService.GetAllDepartmentsWithSubjects(universityId, facultyId, false);

        return Ok(departmentsWithSubjects);
    }

    [HttpGet("{id:Guid}", Name = "GetDepartmentForFaculty")]
    [Authorize(Roles = "University Admin, Faculty Admin, Department Admin")]
    public IActionResult GetDepartment(Guid universityId, Guid facultyId, Guid id)
    {
        var department = _service.DepartmentService.GetDepartment(universityId, facultyId, id, false);

        return Ok(department);
    }

    [HttpPost]
    [Authorize(Roles = "Faculty Admin")]
    public IActionResult CreateDepartment(Guid universityId, Guid facultyId, [FromBody]DepartmentForCreateDto department)
    {
        if (department is null)
            return BadRequest("Object is null");

        var departmentToReturn = _service.DepartmentService.CreateDepartmentForFaculty(universityId, facultyId, department, false);

        return CreatedAtRoute("GetDepartmentForFaculty", new { universityId, facultyId, id = departmentToReturn.Id }, departmentToReturn);
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(Roles = "Faculty Admin")]
    public IActionResult DeleteDepartment(Guid universityId, Guid facultyId, Guid id)
    {
        _service.DepartmentService.DeleteDepartmentForFaculty(universityId, facultyId, id, false);

        return NoContent();
    }

    [HttpPut("{id:Guid}")]
    [Authorize(Roles = "Faculty Admin")]
    public IActionResult UpdateDepartment(Guid universityId, Guid facultyId, Guid id,
        [FromBody] DepartmentForUpdateDto department)
    {
        if (department is null)
            return BadRequest("Object is null");

        _service.DepartmentService.UpdateDepartmentForFaculty(universityId, facultyId, id, department, false, true);

        return NoContent();
    }
}
