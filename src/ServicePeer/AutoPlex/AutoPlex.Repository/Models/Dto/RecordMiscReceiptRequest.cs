using AutoPlex.Repository.Models.Enums;

namespace AutoPlex.Repository.Models.Dto
{
    public class RecordMiscReceiptRequest
    {
        public string Payer { get; set; } = string.Empty;
        public DateTime ReceiptDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string? Reference { get; set; }
        public long BankAccountId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
