using bp.kpir.DAO.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.kpir.DAO.Loads
{
    public class LoadExtraInfoDTO:InvoiceExtraInfoDTO
    {
        public int? InvoiceBuyId { get; set; }
        public string InvoiceBuyNo { get; set; }
        public bool? InvoiceBuyRecived { get; set; }

    }
}
