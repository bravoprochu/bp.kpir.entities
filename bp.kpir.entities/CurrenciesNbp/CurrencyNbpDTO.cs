using System;
using bp.kpir.DAO.Currencies;

namespace bp.kpir.DAO.CurrenciesNbp
{
    public class CurrencyNbpDTO
    {
        public double Price { get; set; }
        public CurrencyDTO Currency { get; set; }
        public double PlnValue { get; set; }
        public double Rate { get; set; }
        public DateTime RateDate { get; set; }
        

    }
}