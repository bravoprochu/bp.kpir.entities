using System.Collections.Generic;

namespace bp.kpir.DAO.Invoice
{
    public class PaymentTerm
    {
        public int PaymentTermId { get; set; }
        public string Name { get; set; }
        public bool IsDescription { get; set; }
        public bool IsPaymentDate { get; set; }

        public List<PaymentTerms> PaymentTermsList { get; set; }
        
        
    }
}