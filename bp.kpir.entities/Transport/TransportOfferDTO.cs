﻿
using bp.kpir.DAO.Loads;
using bp.shared.DTO;

namespace bp.kpir.DAO.Transport
{
    public class TransportOfferDTO
    {
        public int? TransportOfferId { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string Driver { get; set; }
        public string Info { get; set; }
        public bool InvoiceInPLN { get; set; }
        public int? InvoiceSellId { get; set; }
        public string InvoiceSellNo { get; set; }
        public TransportOfferAddressDTO Load { get; set; }
        public string OfferNo { get; set; }
        public TradeInfoDTO TradeInfo { get; set; }
        public TransportOfferAddressDTO Unload { get; set; }
    }
}
