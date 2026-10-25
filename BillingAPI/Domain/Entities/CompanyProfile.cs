using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Entities
{
    public class CompanyProfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public string InvoicePrefix {  get; set; } = "FACT";
        public int NextInvoiceNumber { get; set; }

    }
}
