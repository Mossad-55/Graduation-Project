namespace Entities.Exceptions;

public sealed class QuestionnaireNotFoundException : NotFoundException
{
    public QuestionnaireNotFoundException(Guid id)
        : base($"The questionnaire with id: {id} doesn't exists in the database.")
    {
    }
}
