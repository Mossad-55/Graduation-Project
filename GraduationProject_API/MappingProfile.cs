using AutoMapper;
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
        CreateMap<DepartmentForCreateDto, Department>();
        CreateMap<DepartmentForUpdateDto, Department>();

        // Subject Mapping
        CreateMap<Subject, SubjectDto>()
            .ForMember(s => s.FullName,
            opts => opts.MapFrom(x => string.Join(" - ", x.Name, x.Code)));
        CreateMap<SubjectForCreationDto, Subject>();
        CreateMap<SubjectForUpdateDto, Subject>();

        // Questionnaire Mapping
        CreateMap<Questionnaire, QuestionnaireDto>();
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

        // Faculty Admin Mapping
        CreateMap<User, FacultyAdmin>();
        CreateMap<UserDto, FacultyAdmin>();

        // Department Admin Mapping
        CreateMap<User, DepartmentAdmin>();
        CreateMap<UserDto, DepartmentAdmin>();

        // Professor Mapping
        CreateMap<UserDto, Professor>();
        CreateMap<User, ProfessorDto>()
            .ForMember(p => p.FullName,
            opts => opts.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));
    }
}
