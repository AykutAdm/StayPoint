using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.RoomDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            var result = _mapper.Map<List<ResultRoomDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var value = _roomService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdRoomDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateRoom(CreateRoomDto createRoomDto)
        {
            var room = _mapper.Map<Room>(createRoomDto);
            _roomService.TInsert(room);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            var room = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(room);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _roomService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}
