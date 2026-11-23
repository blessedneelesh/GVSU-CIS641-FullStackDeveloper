using System.Data;
using AutoPlex.Repository.Models;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Interface
{
    public interface ITransactionRepository
    {
        Task<long> GetNextTransactionId(IDbTransaction tx);
        Task<long> InsertTransaction(Transaction transaction, IDbTransaction tx);
        Task<PagedList<TransactionResponseDto>> GetAllTransactions(TransactionParameters parameters);
        Task<TransactionResponseDto?> GetTransactionById(long id);
    }
}
