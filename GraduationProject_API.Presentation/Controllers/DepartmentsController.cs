using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace GraduationProject_API.Presentation.Controllers;

[ApiController]
[Route("api/universities/{universityId}/faculities/{facultyId}/departments")]
public class DepartmentsController : ControllerBase
{
    private readonly IServiceManager _service;

    public DepartmentsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetDepartmentsForFaculty(Guid universityId, Guid facultyId)
    {
        var departments = _service.DepartmentService.GetAllDepartments(universityId, facultyId, false);

        return Ok(departments);
    }

    [HttpGet("low-rate")]
    public IActionResult GetDepartmentsWithLowRate(Guid universityId, Guid facultyId)
    {
        var departmentsWithSubjects = _service.DepartmentService.GetAllDepartmentsWithSubjects(universityId, facultyId, false);

        return Ok(departmentsWithSubjects);
    }

    [HttpGet("{id:Guid}", Name = "GetDepartmentForFaculty")]
    public IActionResult GetDepartment(Guid universityId, Guid facultyId, Guid id)
    {
        var department = _service.DepartmentService.GetDepartment(universityId, facultyId, id, false);

        return Ok(department);
    }

    [HttpPost]
    public IActionResult CreateDepartment(Guid universityId, Guid facultyId, [FromBody]DepartmentForCreateDto department)
    {
        if (department is null)
            return BadRequest("Object is null");

        var departmentToReturn = _service.DepartmentService.CreateDepartmentForFaculty(universityId, facultyId, department, false);

        return CreatedAtRoute("GetDepartmentForFaculty", new { universityId, facultyId, id = departmentToReturn.Id }, departmentToReturn);
    }

    [HttpDelete("{id:Guid}")]
    public IActionResult DeleteDepartment(Guid universityId, Guid facultyId, Guid id)
    {
        _service.DepartmentService.DeleteDepartmentForFaculty(universityId, facultyId, id, false);

        return NoContent();
    }

    [HttpPut("{id:Guid}")]
    public IActionResult UpdateDepartment(Guid universityId, Guid facultyId, Guid id,
        [FromBody] DepartmentForUpdateDto department)
    {
        if (department is null)
            return BadRequest("Object is null");

        _service.DepartmentService.UpdateDepartmentForFaculty(universityId, facultyId, id, department, false, true);

        return NoContent();
    }
}
