using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.SubscribeDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;

        public SubscribesController(ISubscribeService subscribeService, IMapper mapper)
        {
            _subscribeService = subscribeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            var result = _mapper.Map<List<ResultSubscribeDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeById(int id)
        {
            var value = _subscribeService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdSubscribeDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            var subscribe = _mapper.Map<Subscribe>(createSubscribeDto);
            _subscribeService.TInsert(subscribe);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            var subscribe = _mapper.Map<Subscribe>(updateSubscribeDto);
            _subscribeService.TUpdate(subscribe);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _subscribeService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}
