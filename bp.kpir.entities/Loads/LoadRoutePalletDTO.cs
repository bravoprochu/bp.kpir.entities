﻿
using bp.shared.DTO;

namespace bp.kpir.DAO.Loads
{
    public class LoadRoutePalletDTO
    {
        public int? LoadRoutePalletId { get; set; }
        public ValueViewValueDTO Type { get; set; }
        public string Dimmension { get; set; }
        public int Amount { get; set; }
        public bool? Is_stackable { get; set; }
        public bool? Is_exchangeable { get; set; }
        public string Info { get; set; }
    }
}