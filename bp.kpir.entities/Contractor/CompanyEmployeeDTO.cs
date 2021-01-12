﻿namespace bp.kpir.DAO.Contractor
{
    public class CompanyEmployeeDTO
    {
        public int CompanyEmployeeId { get; set; }
        public string CompanyEmployeeInfo { get {
                var tel = string.IsNullOrWhiteSpace(this.Telephone) ? "" : $", tel: {this.Telephone}";
                var email = string.IsNullOrWhiteSpace(this.Email) ? "" : $", {this.Email}";
                return $"{this.Given_name} {this.Family_name}{tel} {Email}";
            } }
        public int Id => this.CompanyEmployeeId;
        public string Given_name { get; set; }
        public string Family_name { get; set; }
        public string Trans_id { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool Entitled { get; set; }
        public bool Hidden { get; set; }
        public bool Is_driver { get; set; }
        public bool Is_moderator { get; set; }
    }
}
