using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Enums;

namespace AutoPlex.Repository.RequestFeatures
{
    public class BankAccountParameters : RequestParameters
    {
        public Status? Status { get; set; }
        public string? Type { get; set; }
        public long? BankId { get; set; }
        public string? SearchTerm { get; set; }
    }
}
