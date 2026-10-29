using Billing.BillingAPI.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        public Customer Customer { get; set; } = null!;
        public string EmployeeId { get; set; } = string.Empty;
        public Employee Employee { get; set; } = null!;
        public DateTime IssueDate { get; set; } = DateTime.UtcNow;
        public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;

        public decimal Subtotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }

        public ICollection<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

    }
}
