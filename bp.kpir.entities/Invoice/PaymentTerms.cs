using bp.kpir.DAO.Loads;
using bp.kpir.DAO.Transport;
using System;

namespace bp.kpir.DAO.Invoice
{
    public class PaymentTerms
    {
      
        public int PaymentTermsId { get; set; }
        public DateTime Day0 { get; set; }
        public int? PaymentDays { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDescription { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public int PaymentTermId { get; set; }



        public TradeInfo TradeInfo { get; set; }
        public int? TradeInfoId { get; set; }
        public InvoiceBuy InvoiceBuy { get; set; }
        public InvoiceSell InvoiceSell { get; set; }
        public TransportOffer TransportOffer { get; set; }

    }
}