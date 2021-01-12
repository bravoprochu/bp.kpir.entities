using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.Loads;
using System.Collections.Generic;

namespace bp.kpir.DAO.Loads
{
    public class LoadSellDTO
    {
        public LoadSellDTO()
        {
            this.ContactPersonsList = new List<CompanyEmployeeDTO>();
        }
        public int? LoadSellId { get; set; }

        public TradeInfoDTO Selling_info { get; set; }
        public CompanyDTO Principal { get; set; }
        public List<CompanyEmployeeDTO> ContactPersonsList { get; set; }
    }
}