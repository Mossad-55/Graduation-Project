namespace Entities.Exceptions;

public sealed class UserCreationFailedException : BadRequestException
{
    public UserCreationFailedException(string userType) 
        : base($"Couldn't register the {userType}. Please try again later.")
    {
    }
}
