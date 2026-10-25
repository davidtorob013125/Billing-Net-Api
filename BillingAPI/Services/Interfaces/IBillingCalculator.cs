using Billing.BillingAPI.Domain.Entities;

namespace Billing.BillingAPI.Services.Interfaces
{
    public interface IBillingCalculator
    {
        void CalculateItemTotals(InvoiceItem item);
        void CalculateInvoiceTotals(Invoice invoice);
    }
}
