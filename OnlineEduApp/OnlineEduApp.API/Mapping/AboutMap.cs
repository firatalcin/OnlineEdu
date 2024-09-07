using AutoMapper;
using OnlineEduApp.Dto.Dtos.AboutDtos;
using OnlineEduApp.Entities.Models;

namespace OnlineEduApp.API.Mapping
{
    public class AboutMap : Profile
    {
        public AboutMap()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
