﻿namespace Entities.Exceptions;

public sealed class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(Guid id) 
        : base($"The user with id: {id} doesn't exist.")
    {
    }
}
