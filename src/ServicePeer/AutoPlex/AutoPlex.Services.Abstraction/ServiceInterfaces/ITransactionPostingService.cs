using System.Data;
using AutoPlex.Repository.Models.Dto;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ITransactionPostingService
    {
        Task<long> PostTransaction(PostTransactionRequest request, IDbTransaction? tx = null);
    }
}
