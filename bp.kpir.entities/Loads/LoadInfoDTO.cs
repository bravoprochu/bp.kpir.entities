namespace bp.kpir.DAO.Loads
{
    public class LoadInfoDTO
    {
        public string Description { get; set; }

        public LoadInfoExtraDTO ExtraInfo { get; set; }

        public double? Load_height { get; set; }
        public double? Load_length { get; set; }
        public double? Load_volume { get; set; }
        public double Load_weight { get; set; }



    }
}