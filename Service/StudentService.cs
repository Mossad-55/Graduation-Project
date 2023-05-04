using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class StudentService : IStudentService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public StudentService(IRepositoryManager repository, IMapper mapper, UserManager<User> userManager)
    {
        _repository = repository;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<StudentDto> GetStudentWithSubjects(Guid id, bool trackChanges)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new UserNotFoundException(id);

        var studentEntity = _repository.Student.GetStudentWithSubjects(id, trackChanges);

        var studentDto = _mapper.Map<StudentDto>(user);
        studentDto.Subjects = _mapper.Map<ICollection<SubjectDto>>(studentEntity.Subjects);

        return studentDto;
    }


    // Private Functions
}
