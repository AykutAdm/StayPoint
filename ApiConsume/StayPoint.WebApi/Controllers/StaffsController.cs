using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.StaffDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffsController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            var result = _mapper.Map<List<ResultStaffDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {
            var value = _staffService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdStaffDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateStaff(CreateStaffDto createStaffDto)
        {
            var staff = _mapper.Map<Staff>(createStaffDto);
            _staffService.TInsert(staff);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateStaff(UpdateStaffDto updateStaffDto)
        {
            var staff = _mapper.Map<Staff>(updateStaffDto);
            _staffService.TUpdate(staff);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _staffService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}
