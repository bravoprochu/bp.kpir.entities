using System;
using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.CurrenciesNbp;
using bp.kpir.DAO.Invoice;
using bp.shared.DTO;

namespace bp.kpir.DAO.Transport
{
    public class TransportOffer : CreationInfo
    {
        public int TransportOfferId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public CurrencyNbp CurrencyNbp { get; set; }
        public int CurrencyNbpId { get; set; }
        public DateTime Date { get; set; }
        public string Driver { get; set; }
        public string Info { get; set; }
        public InvoiceSell InvoiceSell { get; set; }
        public int? InvoiceSellId { get; set; }
        public TransportOfferAddress Load { get; set; }
        public string OfferNo { get; set; }
        public PaymentTerms PaymentTerms { get; set; }
        public int PaymentTermsId { get; set; }
        public TransportOfferAddress Unload { get; set; }


    }
}
