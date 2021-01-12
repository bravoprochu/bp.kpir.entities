﻿using System.Collections.Generic;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceLinesGroupDTO
    {
        public InvoiceLinesGroupDTO()
        {
            this.Current = new InvoiceLineDTO();
            this.Original = new InvoiceLineDTO();
        }   
        public InvoiceLineDTO Corrections { get {
                var res = new InvoiceLineDTO();
                if (this.Current != null && this.Original != null)
                {
                    res.Brutto_value = this.Current.Brutto_value - this.Original.Brutto_value;
                    res.Netto_value = this.Current.Netto_value - this.Original.Netto_value;
                    res.Quantity = this.Current.Quantity - this.Original.Quantity;
                    res.Unit_price = this.Current.Unit_price - this.Original.Unit_price;
                    res.Vat_rate = this.Current.Vat_rate != this.Original.Vat_rate ? "( !!! )" : null;
                    res.Vat_unit_value = this.Current.Vat_unit_value - this.Original.Vat_unit_value;
                    res.Vat_value = this.Current.Vat_value - Original.Vat_value;

                }
                return res;
            }}
        public InvoiceLineDTO Current { get; set; }
        public InvoiceLineDTO Original { get; set; }
    }
}