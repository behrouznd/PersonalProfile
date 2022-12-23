using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace PersonalProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Language, LanguageDto>();
        }
    }
}
