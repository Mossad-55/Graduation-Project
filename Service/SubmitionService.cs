﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTranferObjects;

namespace Service;

internal sealed class SubmitionService : ISubmitionService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public SubmitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public void AddSubmition(Guid questionnaireId, Guid studentId, SubmitionForCreationDto submition, bool trackChanges)
    {
        var questionnaire = _repository.Questionnaire.GetQuestionnaireById(questionnaireId, trackChanges);
        if (questionnaire is null)
            throw new QuestionnaireNotFoundException(questionnaireId);

        var student = _repository.Student.CheckForStudentById(studentId, trackChanges);
        if (!student)
            throw new UserNotFoundException(studentId.ToString());

        var submitionEntity = _mapper.Map<Submition>(submition);

        _repository.Submition.AddSubmition(questionnaireId, studentId, submitionEntity);
        _repository.Save();
    }

    public bool CheckStudentSubmition(Guid questionnaireId, Guid studentId, bool trackChanges)
    {
        var questionnaire = _repository.Questionnaire.GetQuestionnaireById(questionnaireId, trackChanges);
        if (questionnaire is null)
            throw new QuestionnaireNotFoundException(questionnaireId);

        var student = _repository.Student.CheckForStudentById(studentId, trackChanges);
        if (!student)
            throw new UserNotFoundException(studentId.ToString());

        return _repository.Submition.CheckForStudentSubmition(questionnaireId, studentId, trackChanges);
    }
}
