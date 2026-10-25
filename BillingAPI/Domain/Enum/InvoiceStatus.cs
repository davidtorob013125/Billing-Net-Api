using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Domain.Enum
{
    public enum InvoiceStatus
    {
        Draft = 0, // Borrador (Se puede modificar)
        Issued = 1, // Emitida (Congelada, genera consecutivo y descuenta stock)
        Cancelled = 2, // Anulada (Revierte efectos si es necesario)
    }
}
