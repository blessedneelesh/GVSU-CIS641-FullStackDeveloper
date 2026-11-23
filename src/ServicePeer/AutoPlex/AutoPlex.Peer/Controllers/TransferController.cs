using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Services.Abstractions.ServiceInterfaces;

namespace AutoPlex.Peer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransfer([FromBody] CreateTransferRequest request)
        {
            try
            {
                var transfer = await _transferService.CreateTransfer(request);
                return StatusCode(201, transfer);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = new[] { ex.Message } });
            }
        }
    }
}
