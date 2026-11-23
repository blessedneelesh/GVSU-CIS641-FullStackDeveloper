using AutoPlex.Repository.Interface;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;
using AutoPlex.Services.Abstractions.ServiceInterfaces;

namespace AutoPlex.Services.Service
{
    public class StatementLineService : IStatementLineService
    {
        private readonly IBankStatementLineRepository _bankStatementLineRepository;

        public StatementLineService(IBankStatementLineRepository bankStatementLineRepository)
        {
            _bankStatementLineRepository = bankStatementLineRepository;
        }

        public Task<PagedList<StatementLineResponseDto>> GetStatementLines(StatementLineParameters parameters)
        {
            return _bankStatementLineRepository.GetStatementLines(parameters);
        }
    }
}
