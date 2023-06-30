namespace Entities.Exceptions;

public sealed class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(string data) 
        : base($"The user with Email or Id: {data} doesn't exist.")
    {
    }
}
