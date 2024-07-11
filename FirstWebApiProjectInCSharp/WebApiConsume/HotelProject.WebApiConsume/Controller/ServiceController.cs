using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/v1/service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult GetAllServiceList()
        {
            var getAllServiceList = _serviceService.TGetList();
            return Ok(getAllServiceList);
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceListById(int id)
        {
            var getServiceById = _serviceService.TGetById(id);
            return Ok(getServiceById);
        }

        [HttpPost]
        public IActionResult Add(Service service)
        {
            _serviceService.TInsert(service);
            return Ok(service);
        }

        [HttpPut]
        public IActionResult Update(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok(service);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var getServiceById = _serviceService.TGetById(id);
            _serviceService.TDelete(getServiceById);
            return Ok("Deleted Successfully.");
        }
    }
}
