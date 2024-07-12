using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/v1/testimonial")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {

        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var GetAllTestimonial = _testimonialService.TGetList();
            return Ok(GetAllTestimonial);
        }

        [HttpGet("{id}")]
        public ActionResult GetTestimonialById(int id)
        {
            var GetTestimonialById = _testimonialService.TGetById(id);
            return Ok(GetTestimonialById);
        }

        [HttpPost]
        public ActionResult Add(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();    
        }

        [HttpPut]
        public IActionResult Update(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var GetTestimonialById = _testimonialService.TGetById(id);
            _testimonialService.TDelete(GetTestimonialById);
            return Ok();
        }
    }
}
