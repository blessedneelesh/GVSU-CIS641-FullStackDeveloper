using AutoPlex.Repository.Models.Dto;

namespace AutoPlex.Services.Abstractions.ServiceInterfaces
{
    public interface IReceiptService
    {
        Task<ArInvoiceResponseDto?> RecordArPayment(long arInvoiceId, RecordArPaymentRequest request);
        Task<ArInvoiceResponseDto?> GetPaymentHistory(long arInvoiceId);
        Task<BankReceiptResponseDto> RecordMiscReceipt(RecordMiscReceiptRequest request);
    }
}
