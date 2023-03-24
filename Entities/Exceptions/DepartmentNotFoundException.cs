namespace Entities.Exceptions;

public sealed class DepartmentNotFoundException : NotFoundException
{
    public DepartmentNotFoundException(Guid id)
        : base($"The department with id: {id} doesn't exists in the database.")
{
}
}
