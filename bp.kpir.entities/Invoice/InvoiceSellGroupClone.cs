using System;
using System.Collections.Generic;
using System.Text;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceSellGroupClone
    {
        public InvoiceSellGroupClone()
        {
            this.InvoiceList = new List<InvoiceSellLineListDTO>();
        }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfSell { get; set; }
        public List<InvoiceSellLineListDTO> InvoiceList { get; set; }
        public string ProductName { get; set; }
    }
}
