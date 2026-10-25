using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
