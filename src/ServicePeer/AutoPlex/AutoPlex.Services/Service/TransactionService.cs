using AutoPlex.Repository.Interface;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;
using AutoPlex.Services.Abstractions.ServiceInterfaces;

namespace AutoPlex.Services.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Task<PagedList<TransactionResponseDto>> GetAllTransactions(TransactionParameters parameters)
        {
            return _transactionRepository.GetAllTransactions(parameters);
        }

        public Task<TransactionResponseDto?> GetTransactionById(long id)
        {
            return _transactionRepository.GetTransactionById(id);
        }
    }
}
