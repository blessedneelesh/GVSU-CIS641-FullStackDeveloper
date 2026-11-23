using System.Data;
using AutoPlex.Repository.Models;
using AutoPlex.Repository.Models.Dto;
using AutoPlex.Repository.RequestFeatures;

namespace AutoPlex.Repository.Interface
{
    public interface IArInvoiceRepository
    {
        Task<long> InsertArInvoice(ArInvoice arInvoice, IDbTransaction tx);
        Task<ArInvoice?> GetArInvoiceById(long id);
        Task<int> UpdateArPayment(ArInvoice ar, decimal expectedBalance, IDbTransaction tx);
        Task<int> CloseArInvoice(long invoiceId, IDbTransaction tx);
        Task<PagedList<ArAgingDto>> GetAllAr(ArAgingParameters parameters);
        Task<ArDetailDto?> GetArById(long id);
    }
}
