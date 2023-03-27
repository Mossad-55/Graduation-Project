﻿using Entities.Models;

namespace Contracts;

public interface ISubjectRepository
{
    IEnumerable<Subject> GetAllSubjcest(Guid departmentId, bool trackChanges);
    Subject GetSubject(Guid departmentId, Guid id, bool trackChanges);
    void CreateSubject(Guid departmentId, Subject subject);
    void DeleteSubject(Subject subject);
}