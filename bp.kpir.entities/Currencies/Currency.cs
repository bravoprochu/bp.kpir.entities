using bp.kpir.DAO.CurrenciesNbp;
using bp.kpir.DAO.Invoice;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bp.kpir.DAO.Currencies
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        [MaxLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }

        public List<CurrencyNbp> CurrencyNbpList { get; set; }
        public List<InvoiceBuy> InvoiceBuyList { get; set; }
        public List<InvoiceSell> InvoiceSellList { get; set; }



    }
}