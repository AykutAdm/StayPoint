using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.ServiceDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServicesController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            var result = _mapper.Map<List<ResultServiceDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceById(int id)
        {
            var value = _serviceService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdServiceDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateService(CreateServiceDto createServiceDto)
        {
            var service = _mapper.Map<Service>(createServiceDto);
            _serviceService.TInsert(service);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto updateServiceDto)
        {
            var service = _mapper.Map<Service>(updateServiceDto);
            _serviceService.TUpdate(service);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _serviceService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}