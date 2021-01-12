using bp.kpir.DAO.Contractor;

namespace bp.kpir.DAO.Loads
{
    public class LoadSellContactPersons
    {
        public CompanyEmployee CompanyEmployee { get; set; }
        public int CompanyEmployeeId { get; set; }
        public LoadSell LoadSell{ get; set; }
        public int LoadSellId { get; set; }
    }
}
