using System;
using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.Currencies;

namespace bp.kpir.DAO.Invoice
{
    public class InvoicePaymentRemindDTO
    {
        public DateTime PaymentDate { get; set; }

        public CompanyCardDTO Company { get; set; }
        public CurrencyDTO Currency { get; set; }
        public string CorrectionPaymenntInfo { get; set; }
        public int? DaysOverdue { get; set; }
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public InvoiceTotalDTO InvoiceTotal { get; set; }
        public double InvoiceValue { get; set; }

        public bool? IsCmrReceived { get; set; }
        public bool? IsInvoiceSent { get; set; }
        public bool? IsInvoiceReceived { get; set; }
        public bool? IsTransportOrLoadInvoice { get; set; }

        public int? PaymentDays { get; set; }
        public DateTime? ReceivedInvoiceDate { get; set; }

    }
}
