using System;
using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.Loads;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceBuy: InvoiceCommon
    {
        public int InvoiceBuyId { get; set; }
        public Company CompanySeller { get; set; }
        public int CompanySellerId { get; set; }
        public bool InvoiceReceived { get; set; }
        public DateTime? InvoiceReceivedDate { get; set; }

        public Load Load { get; set; }
        public int? LoadId { get; set; }

        public bool PaymentIsDone { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int PaymentTermsId { get; set; }
       
        
    }
}
