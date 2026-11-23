using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPlex.Repository.RequestFeatures
{
    public class PartParameters : RequestParameters
    {
        public string? SearchTerm { get; set; }
        public string? Category { get; set; }
        public bool? LowStockOnly { get; set; }
    }
}
