using System;

namespace bp.kpir.DAO.Transport
{
    public class TransportOfferAddressDTO
    {
        public int? TransportOfferAddressId { get; set; }
        public DateTime Date { get; set; }
        public string Locality { get; set; }
        public string PostalCode { get; set; }
       
    }
}