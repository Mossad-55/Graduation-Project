﻿using AutoMapper;
using Entities.Models;
using Shared.DataTranferObjects;

namespace GraduationProject_API;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
        // All the mapping will be added later.

        // University Mapping
        CreateMap<University, UniversityDto>();
        CreateMap<UniversityForUpdateDto, University>();

        // Faculty Mapping
        CreateMap<Faculty, FacultyDto>();
        CreateMap<FacultyForCreationDto, Faculty>();
        CreateMap<FacultyForUpdateDto, Faculty>();

        // Department Mapping
        CreateMap<Department, DepartmentDto>();
        CreateMap<Department, DepartmentWithSubjectsDto>();
        CreateMap<DepartmentForCreateDto, Department>();
        CreateMap<DepartmentForUpdateDto, Department>();

        // Subject Mapping
        CreateMap<Subject, SubjectDto>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<Subject, SubjectForProfessorDto>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<Subject, SubjectDetailsForStudentDto>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<Subject, SubjectDtoForStudent>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<Subject, SubjectForDepartmentDto>()
            .ForMember(s => s.SubjectName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<SubjectForCreationDto, Subject>();
        CreateMap<SubjectForUpdateDto, Subject>();

        // Questionnaire Mapping
        CreateMap<Questionnaire, QuestionnaireDto>();
        CreateMap<Questionnaire, QuestionnaireForSubjectDto>()
            .ForMember(q => q.DurationInDays,
            opts => opts.MapFrom(x => (x.EndDate - x.CreatedAt).Days))
            .ForMember(q => q.IsActive,
            opts => opts.MapFrom(x => x.EndDate > DateTime.Now));
        CreateMap<QuestionnaireForCreationDto, Questionnaire>();
        CreateMap<QuestionnaireForUpdateDto, Questionnaire>();

        // University Admin Mapping
        CreateMap<User, UserDto>()
            .ForMember(a => a.FullName,
            opts => opts.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
        CreateMap<UserForCreationDto, User>()
            .ForMember(u => u.UserName,
            opts => opts.MapFrom(x => x.Email));
        CreateMap<UserForUpdateDto, User>()
            .ForMember(u => u.UserName,
            opts => opts.MapFrom(x => x.Email));
        CreateMap<UserDto, UniversityAdmin>();
        CreateMap<UniversityAdmin, UniversityAdminDto>();

        // Faculty Admin Mapping
        CreateMap<User, FacultyAdmin>();
        CreateMap<UserDto, FacultyAdmin>();
        CreateMap<FacultyAdmin, FacultyAdminDto>();

        // Department Admin Mapping
        CreateMap<User, DepartmentAdmin>();
        CreateMap<UserDto, DepartmentAdmin>();
        CreateMap<DepartmentAdmin, DepartmentAdminDto>();

        // Professor Mapping
        CreateMap<UserDto, Professor>();
        CreateMap<User, ProfessorDto>()
            .ForMember(p => p.FullName,
            opts => opts.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
        CreateMap<ProfessorDto, Professor>();
        CreateMap<Professor, ProfessorDetailsDto>();

        // Student Mapping
        CreateMap<User, StudentDto>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
        CreateMap<Student, StudentDto>();
        CreateMap<Student, StudentDetailsDto>();

        // Submition Mapping
        CreateMap<Submition, SubmitionDto>();
        CreateMap<SubmitionForCreationDto, Submition>();

        // Subject Conclusion Mapping
        CreateMap<SubjectConclusion, SubjectConclusionDto>()
            .ForCtorParam("Date",
            opts => opts.MapFrom(x => x.Date.ToShortDateString()))
            .ForCtorParam("GoodConclusion",
            opts => opts.MapFrom(x => x.GoodConclusion.Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries)))
            .ForCtorParam("BadConclusion",
            opts => opts.MapFrom(x => x.BadConclusion.Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries)));

        // Recommendation Mapping
        CreateMap<Recommendation, RecommendationDto>()
            .ForCtorParam("Date",
            opts => opts.MapFrom(x => x.Date.ToShortDateString()))
            .ForCtorParam("SubjectName",
            opts => opts.MapFrom(x => x.Subject.Name))
            .ForCtorParam("Content",
            opts => opts.MapFrom(x => x.Content.Split(new[] { '*' }, StringSplitOptions.RemoveEmptyEntries)));
        
    }
}
