using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{

    public class InvoiceResponseDto
    {
        public DateTime IssuedAt { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public List<InvoiceItemResponseDto> Items { get; set; } = new();
        public string Notes { get; set; } = string.Empty;
        public decimal Subtotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class InvoiceCreateDto
    {
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public List<InvoiceItemCreateDto> Items { get; set; } = new();
    }


    public class InvoiceItemResponseDto
    {
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

    public class InvoiceItemCreateDto
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
