namespace Entities.Exceptions;

public sealed class AccessDeniedException : BadRequestException
{
    public AccessDeniedException() 
        : base("You don't have access to enter this site.")
    {
    }
}
