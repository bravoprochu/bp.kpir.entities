﻿using bp.kpir.DAO.Contractor;
using System.Collections.Generic;

namespace bp.kpir.DAO.Loads
{
    public class LoadSell
    {
        public int LoadSellId { get; set; }

        public TradeInfo SellingInfo { get; set; }

        public Company Principal { get; set; }      
        public int PrincipalId { get; set; }

        public Load Load { get; set; }
        public int LoadId { get; set; }

        public List<LoadSellContactPersons> ContactPersonsList { get; set; }

    }
}