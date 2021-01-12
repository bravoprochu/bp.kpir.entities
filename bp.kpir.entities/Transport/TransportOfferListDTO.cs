using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.kpir.DAO.Transport
{
    public class TransportOfferListDTO
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        
        public string DocumentNo { get; set; }
        public string Driver { get; set; }

        public string Fracht { get; set; }
        public string LoadDate { get; set; }
        public string LoadPlace { get; set; }
        public string LoadPostalCode { get; set; }
        public string Seller { get; set; }
        public string StatusCode { get; set; }
        public string UnloadDate { get; set; }
        public string UnloadPlace { get; set; }
        public string UnloadPostalCode { get; set; }
    }
}
