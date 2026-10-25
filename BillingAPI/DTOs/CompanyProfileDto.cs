using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
        public class CompanyProfileCreateDto
        {
            public string Name { get; set; } = string.Empty;
            public string TaxId { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }

        public class CompanyProfileResponseDto
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string TaxId { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }
}
