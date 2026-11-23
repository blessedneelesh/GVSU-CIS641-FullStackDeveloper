using System.Data;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface ICustomerBalanceService
    {
        Task UpdateCustomerTotals(long customerId, IDbTransaction tx);
    }
}
