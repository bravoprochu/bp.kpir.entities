﻿using bp.kpir.DAO.Addresses;
using System;
using System.Collections.Generic;

namespace bp.kpir.DAO.Loads
{
    public class LoadRouteDTO
    {

        public int? LoadRouteId { get; set; }
        public LoadRouteDTO()
        {
            this.Pallets = new List<LoadRoutePalletDTO>();
        }

        public DateTime Loading_date { get; set; }
        public string Loading_type { get; set; }
        public AddressDTO Address { get; set; }
        public GeoDTO Geo { get; set; }
        public string Info { get; set; }
        public List<LoadRoutePalletDTO> Pallets { get; set; }
    }
}