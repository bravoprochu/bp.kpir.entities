using System;

namespace bp.kpir.DAO.Invoice
{
    public class ExtraInfoConfirmationDTO
    {
        public string ConfirmationType { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Info { get; set; }
    }
}
