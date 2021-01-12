using bp.kpir.DAO.Contractor;

namespace bp.kpir.DAO.Loads
{
    public class LoadTransEuContactPerson
    {
        public CompanyEmployee CompanyEmployee { get; set; }
        public int CompanyEmployeeId { get; set; }
        public LoadTransEu LoadTransEu { get; set; }
        public int LoadTransEuId { get; set; }
    }
}