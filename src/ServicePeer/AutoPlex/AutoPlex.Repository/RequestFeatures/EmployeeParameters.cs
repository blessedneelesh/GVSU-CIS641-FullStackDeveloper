using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Repository.Models.Enums;

namespace AutoPlex.Repository.RequestFeatures
{
    public class EmployeeParameters : RequestParameters
    {
        public Status? Status { get; set; }
        public string? Department { get; set; }
        public string? SearchTerm { get; set; }
        public bool? IsSalesperson { get; set; }
    }
}
