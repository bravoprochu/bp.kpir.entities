﻿using bp.kpir.DAO.Contractor;
using bp.kpir.DAO.CurrenciesNbp;
using System.Collections.Generic;

namespace bp.kpir.DAO.Loads
{
    public class LoadTransEuDTO
    {
        public int? LoadTransEuId { get; set; }
        public CurrencyNbpDTO Price { get; set; }
        public CompanyDTO SellingCompany { get; set; }
        public string TransEuId { get; set; }
        public List<CompanyEmployeeDTO> ContactPersonsList { get; set; }
    }
}