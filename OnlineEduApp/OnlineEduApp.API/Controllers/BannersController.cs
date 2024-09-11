using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEduApp.Business.Abstract;
using OnlineEduApp.Dto.Dtos.AboutDtos;
using OnlineEduApp.Dto.Dtos.BannerDtos;
using OnlineEduApp.Entities.Models;

namespace OnlineEduApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.Delete(id);
            return Ok("Hakkımızda Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.Create(newValue);
            return Ok("Yeni Banner Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var newValue = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.Update(newValue);
            return Ok("Banner Alanı Güncellendi");
        }
    }
}
