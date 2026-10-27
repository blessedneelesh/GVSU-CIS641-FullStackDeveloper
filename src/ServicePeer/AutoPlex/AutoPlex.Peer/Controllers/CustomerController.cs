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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers([FromQuery] CustomerParameters customerParameters)
        {
            var customers = await _customerService.GetAllCustomers(customerParameters);
            return Ok(new { items = customers, metaData = customers.MetaData });
        }
    }
}
