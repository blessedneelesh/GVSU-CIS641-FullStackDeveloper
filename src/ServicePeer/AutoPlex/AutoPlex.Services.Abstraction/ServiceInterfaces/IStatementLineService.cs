using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface IStatementLineService
    {
        Task<PagedList<StatementLineResponseDto>> GetStatementLines(StatementLineParameters parameters);
    }
}
