using System;
using bp.kpir.DAO.Currencies;
using bp.kpir.DAO.Loads;
using bp.kpir.DAO.Transport;


namespace bp.kpir.DAO.CurrenciesNbp
{
    public class CurrencyNbp
    {
        public int CurrencyNbpId { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public double PlnValue { get; set; }
        public double Rate { get; set; }
        public DateTime RateDate{ get; set; }

        public TradeInfo TradeInfo { get; set; }
        public int? TradeInfoId { get; set; }

        public LoadTransEu LoadTransEu { get; set; }
        public int? LoadTransEuId { get; set; }

        public TransportOffer TransportOffer { get; set; }
        public int? TransportOfferId { get; set; }

    }
}