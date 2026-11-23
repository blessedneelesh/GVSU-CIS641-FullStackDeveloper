using Microsoft.AspNetCore.Mvc;
using AutoPlex.Repository.RequestFeatures;
using AutoPlex.Services.Abstractions.ServiceInterfaces;

namespace AutoPlex.Peer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactions([FromQuery] TransactionParameters parameters)
        {
            var transactions = await _transactionService.GetAllTransactions(parameters);
            return Ok(new { items = transactions, metaData = transactions.MetaData });
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactionById([FromQuery] long id)
        {
            var transaction = await _transactionService.GetTransactionById(id);
            return transaction is null ? NotFound() : Ok(transaction);
        }
    }
}
