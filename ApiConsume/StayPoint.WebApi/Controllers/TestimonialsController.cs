using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StayPoint.BusinessLayer.Abstract;
using StayPoint.DtoLayer.Dtos.TestimonialDtos;
using StayPoint.EntityLayer.Concrete;

namespace StayPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetList();
            var result = _mapper.Map<List<ResultTestimonialDto>>(values);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var value = _testimonialService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetByIdTestimonialDto>(value);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TInsert(testimonial);
            return Ok("Ekleme işlemi başarılı.");
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(testimonial);
            return Ok("Güncelleme işlemi başarılı.");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _testimonialService.TDelete(value);
            return Ok("Silme işlemi başarılı.");
        }
    }
}
