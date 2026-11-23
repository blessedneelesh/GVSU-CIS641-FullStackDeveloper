using AutoPlex.Repository.Models.Enums;

namespace AutoPlex.Repository.Models
{
    public class BankAccount
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal OpeningBalance { get; set; }
        public decimal BookBalance { get; set; }
        public Status Status { get; set; }
    }
}
