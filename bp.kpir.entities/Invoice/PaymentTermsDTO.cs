using System;

namespace bp.kpir.DAO.Invoice
{
    public class PaymentTermsDTO
    {
        public string PaymentTermsCombined
        {
            get
            {

                string description = this.PaymentTerm.IsDescription ? ", " + this.Description : null;
                string paymentDate = this.PaymentTerm.IsPaymentDate ? $", {PaymentDays.Value} dni,  termin płatności: " + this.PaymentDate.Value.ToLocalTime().ToShortDateString() : null;
                return $"{this.PaymentTerm.Name}{paymentDate}{description}";
            }
        }
        public string Description { get; set; }
        public DateTime Day0 { get; set; }
        public int PaymentTermsId { get; set; }
        public PaymentTermDTO PaymentTerm { get; set; }

        public DateTime? PaymentDate { get; set; }
        public int? PaymentDays { get; set; }

    }
}