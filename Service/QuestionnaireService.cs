using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class QuestionnaireService : IQuestionnaireService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public QuestionnaireService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public QuestionnaireDto CreateQuestionnaireForSubject(Guid departmentId, Guid subjectId, QuestionnaireForCreationDto questionnaire, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubject(departmentId, subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var questionnaireEntity = _mapper.Map<Questionnaire>(questionnaire);

        _repository.Questionnaire.CreateQuestionnaire(subjectId, questionnaireEntity);
        _repository.Save();

        var questionnaireToReturn = _mapper.Map<QuestionnaireDto>(questionnaireEntity);
        return questionnaireToReturn;
    }

    public void DeleteQuestionnaireForSubject(Guid departmentId, Guid subjectId, Guid id, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubject(departmentId, subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var questionnaireFromDb = _repository.Questionnaire.GetQuestionnaire(subjectId, id, trackChanges);
        if (questionnaireFromDb is null)
            throw new QuestionnaireNotFoundException(id);

        _repository.Questionnaire.DeleteQuestionnaire(questionnaireFromDb);
        _repository.Save();
    }

    public IEnumerable<QuestionnaireDto> GetAllQuestionnaires(Guid departmentId, Guid subjectId, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubject(departmentId, subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var questionnairesFromDb = _repository.Questionnaire.GetAllQuestionnaires(subjectId, trackChanges);
        var questionnairesDto = _mapper.Map<IEnumerable<QuestionnaireDto>>(questionnairesFromDb);

        return questionnairesDto;
    }

    public QuestionnaireDto GetQuestionnaire(Guid departmentId, Guid subjectId, Guid id, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubject(departmentId, subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var questionnaireFromDb = _repository.Questionnaire.GetQuestionnaire(subjectId, id, trackChanges);
        if (questionnaireFromDb is null)
            throw new QuestionnaireNotFoundException(id);

        var questionnaireDto = _mapper.Map<QuestionnaireDto>(questionnaireFromDb);
        return questionnaireDto;
    }

    public void UpdateQuestionnaireForSubject(Guid departmentId, Guid subjectId, Guid id, QuestionnaireForUpdateDto questionnaire, bool otherTrackChanges, bool quesTrackChanges)
    {
        var subject = _repository.Subject.GetSubject(departmentId, subjectId, otherTrackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var questionnaireEntity = _repository.Questionnaire.GetQuestionnaire(subjectId, id, quesTrackChanges);
        if (questionnaireEntity is null)
            throw new QuestionnaireNotFoundException(id);

        _mapper.Map(questionnaire, questionnaireEntity);
        _repository.Save();
    }
}
