using System.ComponentModel.DataAnnotations;

namespace bp.kpir.DAO.Addresses
{
    public class AddressDTO
    {
        public int AddressId { get; set; }
        public string AddressCombined { get {
                return $"({this.Country}) {this.Postal_code} {this.Locality}, {this.Street_address} {this.Street_number}";
            } }
        public string Address_type { get; set; }
        [MaxLength(2)]
        public string Country { get; set; }
        public string Locality { get; set; }
        [MaxLength(12)]
        public string Postal_code { get; set; }
        public string Street_address { get; set; }
        public string Street_number { get; set; }
    }
}
