using Microsoft.AspNetCore.Mvc;
using AutoPlex.Repository.RequestFeatures;
using AutoPlex.Services.Abstractions.ServiceInterfaces;

namespace AutoPlex.Peer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StatementLineController : ControllerBase
    {
        private readonly IStatementLineService _statementLineService;

        public StatementLineController(IStatementLineService statementLineService)
        {
            _statementLineService = statementLineService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatementLines([FromQuery] StatementLineParameters parameters)
        {
            var lines = await _statementLineService.GetStatementLines(parameters);
            return Ok(new { items = lines, metaData = lines.MetaData });
        }
    }
}
