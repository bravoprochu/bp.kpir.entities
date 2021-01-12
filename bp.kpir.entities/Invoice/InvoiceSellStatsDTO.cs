using bp.kpir.DAO.Currencies;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceSellStatsDTO
    {
        public CurrencyDTO Currency { get; set; }
        public InvoiceTotalDTO Total { get; set; }
        public double InvoiceValue { get; set; }
    }
}
