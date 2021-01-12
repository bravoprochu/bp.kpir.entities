using bp.kpir.DAO.Addresses;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bp.kpir.DAO.Contractor
{
    public class CompanyDTO
    {
        public CompanyDTO()
        {
            this.AddressList = new List<AddressDTO>();
            this.EmployeeList = new List<CompanyEmployeeDTO>();
            this.BankAccountList = new List<BankAccountDTO>();

        }

        public int? CompanyId { get; set; }
        public string ContactInfo
        {
            get
            {
                var result = string.IsNullOrWhiteSpace(this.Telephone) ? "" : $"tel: {this.Telephone}";
                result += result.Length > 2 ? ", " : "";
                result += string.IsNullOrWhiteSpace(this.Email) ? "" : $"email: {this.Email}";
                return result;
            }
        }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Fax { get; set; }
        public int? Trans_id { get; set; }
        public string Legal_name { get; set; }
        public string Native_name { get; set; }
        public string Short_name { get; set; }
        public string Telephone { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        public string Vat_id { get; set; }
        public List<AddressDTO> AddressList { get; set; }
        public List<CompanyEmployeeDTO> EmployeeList { get; set; }
        public List<BankAccountDTO> BankAccountList { get; set; }
    }
}
