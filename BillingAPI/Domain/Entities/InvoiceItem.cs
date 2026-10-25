using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Entities
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Discount { get; set; }
        

        public decimal SubtotalLine { get; set; }
        public decimal TaxAmountLine { get; set; }
        public decimal TotalDiscountLine { get; set; }
        public decimal TotalLine { get; set; }


    }
}
