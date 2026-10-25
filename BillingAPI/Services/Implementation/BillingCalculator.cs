using Billing.BillingAPI.Domain.Entities;
using Billing.BillingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Billing.BillingAPI.Services.Implementation
{
    public class BillingCalculator : IBillingCalculator
    {
        public void CalculateItemTotals(InvoiceItem Item)
        {
            decimal price = Item.UnitPrice;
            decimal discount = 0;
            if (Item.Discount > 0)
            {
                discount = Item.UnitPrice * Item.Discount;
                price = price - discount;
            }
            
            Item.SubtotalLine = Math.Round(price * Item.Quantity, 2);
            Item.TaxAmountLine = Math.Round(Item.SubtotalLine * Item.TaxRate, 2);
            Item.TotalDiscountLine = Math.Round(discount * Item.Quantity, 2);
            Item.TotalLine = Math.Round(Item.SubtotalLine + Item.TaxAmountLine, 2);
        }

        public void CalculateInvoiceTotals(Invoice invoice)
        {
            decimal subtotal = 0;
            decimal tax = 0;
            decimal discount = 0;

            foreach (var item in invoice.Items)
            {
                CalculateItemTotals(item);
                subtotal += item.SubtotalLine;
                tax += item.TaxAmountLine;
                discount += item.TotalDiscountLine;
            }

            invoice.Subtotal = Math.Round(subtotal, 2);
            invoice.TaxAmount = Math.Round(tax, 2);
            invoice.TotalDiscount = Math.Round(discount, 2);
            invoice.TotalAmount = Math.Round(subtotal + tax, 2);
        }
    }
}
