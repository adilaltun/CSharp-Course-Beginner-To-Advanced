﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/v1/room")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var getAllRoomList = _roomService.TGetList();
            return Ok(getAllRoomList);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var roomById = _roomService.TGetById(id);
            _roomService.TDelete(roomById);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var getRoomById=  _roomService.TGetById(id);
            return Ok(getRoomById);
        }

    }
}
