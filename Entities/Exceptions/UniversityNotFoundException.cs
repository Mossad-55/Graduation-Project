namespace Entities.Exceptions;

public sealed class UniversityNotFoundException : NotFoundException
{
    public UniversityNotFoundException(Guid id) 
        : base($"The university with id: {id} doesn't exists in the database.")
    {
    }
}
