using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
    public class InvoiceCreateDto
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public List<InvoiceItemCreateDto> Items { get; set; } = new();
    }

    public class InvoiceItemCreateDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class InvoiceResponseDto
    {
        public int Id { get; set; }
        public DateTime IssuedAt { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public List<InvoiceItemResponseDto> Items { get; set; } = new();
    }

    public class InvoiceItemResponseDto
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
