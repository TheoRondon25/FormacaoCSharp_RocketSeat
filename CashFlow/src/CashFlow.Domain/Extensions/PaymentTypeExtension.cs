using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashFlow.Domain.Enums;
using CashFlow.Domain.Reports.PaymentTypeResource;

namespace CashFlow.Domain.Extensions;
public static class PaymentTypeExtension
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourceReportPaymentType.CASH,
            PaymentType.CreditCard => ResourceReportPaymentType.CREDIT_CARD,
            PaymentType.DebitCard => ResourceReportPaymentType.DEBIT_CARD,
            PaymentType.EletronicTransfer => ResourceReportPaymentType.ELETRONIC_TRANSFER,
            _ => string.Empty
        };
    }
}
