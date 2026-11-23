using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;
using AutoPlex.Services.Abstractions.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
namespace AutoPlex.Peer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVehicles([FromQuery] VehicleParameters parameters)
        {
            try
            {
                var vehicles = await _vehicleService.GetAllVehicles(parameters);
                return Ok(new { items = vehicles, metaData = vehicles.MetaData });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVehicleById([FromQuery] long id)
        {
            var vehicle = await _vehicleService.GetVehicleById(id);
            return vehicle is null ? NotFound() : Ok(vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle([FromBody] VehicleCreateDto vehicle)
        {
            try
            {
                var created = await _vehicleService.AddVehicle(vehicle);
                return StatusCode(201, created);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
