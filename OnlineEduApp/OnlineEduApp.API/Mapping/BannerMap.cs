using AutoMapper;
using OnlineEduApp.Dto.Dtos.BannerDtos;
using OnlineEduApp.Entities.Models;

namespace OnlineEduApp.API.Mapping
{
    public class BannerMap : Profile
    {
        public BannerMap()
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();

        }
    }
}
