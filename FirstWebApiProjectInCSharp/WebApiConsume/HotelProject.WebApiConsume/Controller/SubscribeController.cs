using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/v1/subscribe")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {

        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var GetAllSubscribe = _subscribeService.TGetList();
            return Ok(GetAllSubscribe);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeById(int id)
        {
            var GetSubscribeById = _subscribeService.TGetById(id);
            return Ok(GetSubscribeById);
        }

        [HttpPost]
        public IActionResult Add(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var GetSubscribeById = _subscribeService.TGetById(id);
            _subscribeService.TDelete(GetSubscribeById);
            return Ok();
        }

    }
}
