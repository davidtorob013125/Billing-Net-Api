using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
    public class ProductCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }

    public class ProductResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
