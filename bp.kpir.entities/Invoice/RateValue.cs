﻿using System.Collections.Generic;

namespace bp.kpir.DAO.Invoice
{
    public class RateValue
    {
        public int RateValueId { get; set; }
        public bool IsInactive { get; set; }
        public double BruttoValue { get; set; }
        public double NettoValue { get; set; }
        public string VatRate { get; set; }
        public double VatValue { get; set; }


        public InvoiceBuy InvoiceBuy { get; set; }
        public int? InvoiceBuyId { get; set; }
        public InvoiceSell InvoiceSell { get; set; }
        public int? InvoiceSellId { get; set; }

    }
}