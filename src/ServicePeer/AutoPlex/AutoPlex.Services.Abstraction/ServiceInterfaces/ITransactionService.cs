using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ITransactionService
    {
        Task<PagedList<TransactionResponseDto>> GetAllTransactions(TransactionParameters parameters);
        Task<TransactionResponseDto?> GetTransactionById(long id);
    }
}
