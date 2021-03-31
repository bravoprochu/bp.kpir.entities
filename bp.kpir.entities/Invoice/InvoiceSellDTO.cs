﻿using bp.kpir.DAO.Contractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.kpir.DAO.Invoice
{
    public class InvoiceSellDTO : InvoiceCommonDTO
    {
        public CompanyDTO CompanyBuyer { get; set; }
        public CompanyDTO CompanySeller { get; set; }

        public int InvoiceSellId { get; set; }
        public int BaseInvoiceId { get; set; }

        public int? CorrectionId { get; set; }
        //public string CorrectionTotalInfo { get; set; }
        public InvoiceExtraInfoDTO ExtraInfo { get; set; }

        public string GetInvoiceNo
        {
            get
            {
                string type = this.IsCorrection ? "Faktura korygująca " : "Faktura VAT ";
                return $"{type} {this.InvoiceNo}";
            }
        }
        public double GetInvoiceValue
        {
            get
            {
                double res = 0;
                if (IsCorrection)
                {
                    if (InvoiceOriginalPaid && this.InvoiceTotal.Corrections.Total_brutto < 0)
                    {
                        res = this.InvoiceTotal.Corrections.Total_brutto;
                    }
                    if (InvoiceOriginalPaid && this.InvoiceTotal.Corrections.Total_brutto >= 0)
                    {

                        res = this.InvoiceTotal.Corrections.Total_brutto;
                    }
                    if (!InvoiceOriginalPaid)
                    {
                        res = this.InvoiceTotal.Current.Total_brutto;
                    }
                }
                else
                {
                    res = this.InvoiceTotal.Current.Total_brutto;
                }
                return res;
            }
        }
        public string GetCorrectionPaymenntInfo
        {
            get
            {
                string isToPayOrToReturn = this.IsPaymentToReturn ? "Do zwrotu" : "Do zapłaty";
                return $"{isToPayOrToReturn} {this.InvoiceTotal.Corrections.Total_brutto.ToString("# ##0.00")} {Currency?.Name}";
            }
        }

        public string InvoiceOriginalNo { get; set; }
        public bool InvoiceOriginalPaid { get; set; }
        public string InvoiceType { get; set; }

        public bool IsPaymentToReturn => this.InvoiceTotal.Corrections.Total_brutto < 0;
        public bool IsToRepeat { get; set; }
        public bool PaymentIsDone { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
