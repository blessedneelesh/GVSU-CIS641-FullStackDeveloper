using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Enums;

namespace AutoPlex.Repository.RequestFeatures
{
    public class VendorParameters : RequestParameters
    {
        public Status? Status { get; set; }
        public VendorType? Type { get; set; }
        public string? SearchTerm { get; set; }
    }
}
