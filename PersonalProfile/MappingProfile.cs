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
            CreateMap<Education, EducationDto>();
            CreateMap<Experience, ExperienceDto>();
            CreateMap<SocialMedia, SocialMediaDto>();
            CreateMap<Certificate, CertificateDto>();
            CreateMap<PersonalInfo, PersonalInfoDto>();
            CreateMap<LanguageForCreationDto, Language>();

               /* .ConstructUsing(x => new PersonalInfoDto(x.Id, x.Name, x.Family, x.Title, x.Nationality, x.Birthday, 
                x.MaritalStatus, x.Residence, x.Phone, x.Mobile, x.Email
                , x.Address, x.Introduction, x.PicProfile ));
               */
            //.ForMember(c => c.FullName, opt => opt.MapFrom(x => string.Join(' ', x.Name, x.Family)));

            //.ForCtorParam("FullName", opt => opt.MapFrom(x => string.Join(' ', x.Name, x.Family)))
            //.DisableCtorValidation();

            
        }
    }
}
