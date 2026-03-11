using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.GuestDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestsController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            var result = _mapper.Map<List<ResultGuestDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetGuestById(int id)
        {
            var value = _guestService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdGuestDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateGuest(CreateGuestDto createGuestDto)
        {
            var guest = _mapper.Map<Guest>(createGuestDto);
            _guestService.TInsert(guest);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            var guest = _mapper.Map<Guest>(updateGuestDto);
            _guestService.TUpdate(guest);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _guestService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}
