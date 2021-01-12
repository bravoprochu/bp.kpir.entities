using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bp.kpir.DAO.Loads;

namespace bp.kpir.DAO.Loads
{
    public class LoadBuyDTO
    {
        public LoadBuyDTO()
        {
            this.Routes = new List<LoadRouteDTO>();
        }
        public int? LoadBuyId { get; set; }
        public TradeInfoDTO Buying_info { get; set; }
        public LoadInfoDTO Load_info { get; set; }
        public List<LoadRouteDTO> Routes { get; set; }

    }
}
