using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class SubjectConclusionService : ISubjectConclusionService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    private readonly ILoggerManager _logger;
    public SubjectConclusionService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public SubjectConclusionDto GetConclusionForQuestionnaire(Guid questionnaireId, bool trackChanges)
    {
        var questionnaire = _repository.Questionnaire.GetQuestionnaireById(questionnaireId, trackChanges);
        if (questionnaire is null)
            throw new QuestionnaireNotFoundException(questionnaireId);

        var conclusion = _repository.SubjectConclusion.GetSubjectConclusionForQuestionnaire(questionnaireId, trackChanges);
        if (conclusion is null)
            return null;

        var conclusionDto = _mapper.Map<SubjectConclusionDto>(conclusion);

        return conclusionDto;
    }

    public SubjectConclusionDto GetLatestConclusionForSubject(Guid subjectId, bool trackChanges)
    {
        var subject = _repository.Subject.GetSubjectById(subjectId, trackChanges);
        if (subject is null)
            throw new SubjectNotFoundException(subjectId);

        var subjectConclusion = _repository.SubjectConclusion.GetLatestConclusionForSubject(subjectId, trackChanges);
        if (subjectConclusion is null)
            return null;

        var subjectConclusionDto = _mapper.Map<SubjectConclusionDto>(subjectConclusion);

        return subjectConclusionDto;
    }
}
