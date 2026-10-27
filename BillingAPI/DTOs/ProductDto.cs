using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
    public class ProductResponseDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProductCreateDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public int Stock { get; set; }
        public bool IsActive {  get; set; }
    }

    public class ProductUpdateDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal? UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TaxRate { get; set; }
        public int? Stock { get; set; }
        public bool? IsActive { get; set; }
    }
}
