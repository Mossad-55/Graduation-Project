namespace Entities.Exceptions;

public sealed class SubmitionFoundException : BadRequestException
{
    public SubmitionFoundException(Guid studentId) 
        : base($"Student With Id: {studentId} Has Submitited The Questionnaire Before.")
    {
    }
}
