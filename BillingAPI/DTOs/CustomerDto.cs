using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.DTOs
{
    
    public class CustomerResponseDto
    {
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }

    public class CustomerCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

    public class CustomerUpdateDto
    {
        public string? Name { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; } 
        public string? Email { get; set; } 
        public string? Address { get; set; } 
        public bool? IsActive { get; set; }
    }
}
