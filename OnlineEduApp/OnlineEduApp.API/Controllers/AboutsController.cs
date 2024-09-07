using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEduApp.Business.Abstract;
using OnlineEduApp.Dto.Dtos.AboutDtos;
using OnlineEduApp.Entities.Models;

namespace OnlineEduApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var value = _aboutService.GetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            _aboutService.Delete(id);
            return Ok("Hakkımızda Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto) 
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _aboutService.Create(newValue); 
            return Ok("Yeni Hakkımızda Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto) 
        {
            var newValue = _mapper.Map<About>(updateAboutDto);
            _aboutService.Update(newValue);
            return Ok("Hakkımızda Alanı Güncellendi");
        }
    }
}
