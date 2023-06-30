namespace Entities.Exceptions;

public sealed class WrongEmailOrPasswordException : BadRequestException
{
    public WrongEmailOrPasswordException() 
        : base("You have entered an invalid Email or Password")
    {
    }
}
