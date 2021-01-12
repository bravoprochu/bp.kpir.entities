﻿using bp.kpir.DAO.Loads;
using bp.kpir.DAO.Invoice;
using bp.kpir.DAO.Addresses;
using bp.kpir.DAO.Transport;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bp.kpir.DAO.Contractor
{
    public class Company
    {
        //public Company()
        //{
        //    this.AddressList = new List<Address.Address>();
        //    this.EmployeeList = new List<CompanyEmployee>();
        //    this.BankAccountList = new List<BankAccount>();
        //}
        public int CompanyId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Fax { get; set; }
        public int TransId { get; set; }
        public string Legal_name { get; set; }
        public string Native_name { get; set; }
        public string Short_name { get; set; }
        public string Telephone { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        public string Vat_id { get; set; }
        public List<Address> AddressList { get; set; }
        public List<CompanyEmployee> EmployeeList { get; set; }
        public List<BankAccount> BankAccountList { get; set; }


        public List<TradeInfo> TradeInfoList { get; set; }
        public List<LoadSell> LoadSellList { get; set; }
        public List<LoadTransEu> LoadTransEuList { get; set; }
        public List<InvoiceBuy> InvoiceBuyList { get; set; }
        
        public List<InvoiceSell> InvoiceSellBuyerList { get;set; }
        public List<InvoiceSell> InvoiceSellSellerlList { get; set; }
        public List<TransportOffer> TransportOfferList { get; set; }

    }
}
