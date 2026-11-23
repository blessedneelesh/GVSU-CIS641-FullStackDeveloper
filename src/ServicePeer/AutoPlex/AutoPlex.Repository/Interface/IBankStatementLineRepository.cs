using System.Data;
using AutoPlex.Repository.Models;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Interface
{
    public interface IBankStatementLineRepository
    {
        Task<decimal?> GetLastRunningBalance(long bankAccountId, IDbTransaction tx);
        Task<long> InsertStatementLine(BankStatementLine line, IDbTransaction tx);
        Task<PagedList<StatementLineResponseDto>> GetStatementLines(StatementLineParameters parameters);
    }
}
