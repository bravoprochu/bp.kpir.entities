using System;
using bp.kpir.DAO.Contractor;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceBuyDTO:InvoiceCommonDTO
    {
        public int InvoiceBuyId { get; set; }
        public CompanyDTO CompanySeller { get; set; }
        public bool? IsInvoiceReceived { get; set; }
        public DateTime? InvoiceReceivedDate { get; set; }
        public int? LoadId { get; set; }
        public string LoadNo { get; set; }
        public bool PaymentIsDone { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
