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
        CreateMap<UniversityForCreationDto, University>();
    }
}
