using System;
using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.CurrenciesNbp;
using bp.kpir.DAO.Invoice;


namespace bp.kpir.DAO.Loads
{
    public class TradeInfoDTO
    {
        public int TradeInfoId { get; set; }
        public CompanyDTO Company { get; set; }
        public DateTime Date { get; set; }
        public PaymentTermsDTO PaymentTerms { get; set; }
        public CurrencyNbpDTO Price { get; set; }
    }
}