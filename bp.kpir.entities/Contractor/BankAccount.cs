using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.kpir.DAO.Contractor
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string Swift { get; set; }
        public string Account_no { get; set; }
        public string Type { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
