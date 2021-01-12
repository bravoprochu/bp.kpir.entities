using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceSellListDTO
    {
        public int Id { get; set; }

        public string Brutto { get; set; }
        public string DataSprzedazy { get; set; }
        public string DocumentNo { get; set; }
        public string Nabywca { get; set; }
        public string Netto { get; set; }
        public string Podatek { get; set; }
        public string Type { get; set; }
        public string Waluta { get; set; }
    }
}
