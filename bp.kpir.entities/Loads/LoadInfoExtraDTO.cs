﻿
using System.Collections.Generic;
using bp.shared.DTO;

namespace bp.kpir.DAO.Loads
{
    public class LoadInfoExtraDTO
    {
        public LoadInfoExtraDTO()
        {
            this.Required_ways_of_loading = new List<ValueViewValueDTO>();
            this.Required_adr_classes = new List<ValueViewValueDTO>();
        }

        public bool? Is_ltl { get; set; }
        public bool? Is_lift_required { get; set; }
        public bool? Is_truck_crane_required { get; set; }
        public bool? Is_tir_cable_required { get; set; }
        public bool? Is_tracking_system_required { get; set; }
        public bool? Is_for_clearence { get; set; }
        public List<ValueViewValueDTO> Required_ways_of_loading { get; set; }
        public List<ValueViewValueDTO> Required_adr_classes { get; set; }
        public ValueViewValueDTO Required_truck_body { get; set; }
        public ValueViewValueDTO Type_of_load { get; set; }

    }
}