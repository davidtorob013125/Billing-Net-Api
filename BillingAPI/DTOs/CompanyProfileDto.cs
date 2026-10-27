using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
    public class CompanyProfileResponseDto
    {
        public string Name { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string InvoicePrefix { get; set; } = string.Empty;
    }

    public class CompanyProfileCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string InvoicePrefix { get; set; } = string.Empty;
    }

    public class CompanyProfileUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string InvoicePrefix { get; set; } = string.Empty;
    }
}
