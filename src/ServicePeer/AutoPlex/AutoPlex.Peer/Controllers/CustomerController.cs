using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Services.Abstractions.ServiceInterfaces;
using AutoPlex.Repository.RequestFeatures;
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
            return Ok(customers);
        }
    }
}
