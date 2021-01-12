using bp.kpir.DAO.Loads;
using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.Transport;
using System;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceSell: InvoiceCommon
    {
        public int InvoiceSellId { get; set; }
        public int? BaseInvoiceId { get; set; }
        public Company Buyer { get; set; }
        public int BuyerId { get; set; }
        public int? CorrectiondId { get; set;}
        public string CorrectionTotalInfo { get; set; }
        public InvoiceExtraInfo ExtraInfo { get; set; }
        public bool IsCorrection { get; set; }
        public bool IsInactive { get; set; }
        public Load Load { get; set; }
        public int? LoadId { get; set; }
        public bool PaymentIsDone { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int PaymentTermsId { get; set; }
        public Company Seller { get; set; }
        public int SellerId { get; set; }
        public TransportOffer TransportOffer { get; set; }
        public int? TransportOfferId { get; set; }
    }
}
