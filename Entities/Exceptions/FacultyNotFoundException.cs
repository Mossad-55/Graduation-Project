namespace Entities.Exceptions;

public sealed class FacultyNotFoundException : NotFoundException
{
    public FacultyNotFoundException(Guid id)
        : base($"The faculty with id: {id} doesn't exists in the database.")
    {
    }
}
