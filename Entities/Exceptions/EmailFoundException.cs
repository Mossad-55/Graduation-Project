namespace Entities.Exceptions;

public sealed class EmailFoundException : BadRequestException
{
    public EmailFoundException(string email) 
        : base($"The email: {email} is already registered.")
    {
    }
}
