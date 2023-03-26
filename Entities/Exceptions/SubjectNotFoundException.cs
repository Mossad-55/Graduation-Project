namespace Entities.Exceptions;

public sealed class SubjectNotFoundException : NotFoundException
{
    public SubjectNotFoundException(Guid id)
        : base($"The subject with id: {id} doesn't exists in the database.")
    {
    }
}
