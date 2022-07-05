using Api.DTOs;
using Api.Entities;
using AutoMapper;

namespace Api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.PhtotUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url)).ReverseMap();
            CreateMap<Photo, PhotoDto>();
        }
    }
}
