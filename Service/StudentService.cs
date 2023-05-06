using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
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

    public async Task<ICollection<SubjectDtoForStudent>> GetStudentSubjectsWithQuestionnaires(Guid id, bool trackChanges)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new UserNotFoundException(id);

        var studentEntity = _repository.Student.GetStudentWithSubjects(id, trackChanges);

        var subjectsDto = _mapper.Map<ICollection<SubjectDtoForStudent>>(studentEntity.Subjects);
        foreach(var subject in subjectsDto)
            subject.Questionnaire = _mapper.Map<QuestionnaireForSubjectDto>(_repository.Questionnaire.GetActiveQuestionnaireForSubject(subject.Id, trackChanges));

        return subjectsDto;
    }

    public async Task<StudentDto> GetStudentWithSubjects(Guid id, bool trackChanges)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new UserNotFoundException(id);

        var studentEntity = _repository.Student.GetStudentWithSubjects(id, trackChanges);

        var studentDto = _mapper.Map<StudentDto>(user);
        studentDto.Subjects = _mapper.Map<ICollection<SubjectDetailsForStudentDto>>(studentEntity.Subjects);

        return studentDto;
    }


    // Private Functions
}
