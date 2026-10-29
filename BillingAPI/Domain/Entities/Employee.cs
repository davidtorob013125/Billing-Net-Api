using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TypeCountBancary { get; set; } = string.Empty;
        public string NameCountBancary { get; set; } = string.Empty;
        public string CountBancary { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    }
}
