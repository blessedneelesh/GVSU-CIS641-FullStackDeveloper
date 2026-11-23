using System.Data;
using AutoPlex.Repository.Models;

namespace AutoPlex.Repository.Interface
{
    public interface IBankReceiptRepository
    {
        Task<long> InsertBankReceipt(BankReceipt receipt, IDbTransaction tx);
        Task<IEnumerable<BankReceipt>> GetReceiptsByArInvoiceId(long arInvoiceId);
    }
}
