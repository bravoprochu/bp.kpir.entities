using System.Collections.Generic;

namespace bp.kpir.DAO.Loads
{
    public class ViewValueGroupName
    {
        public int ViewValueGroupNameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ViewValueDictionary> ViewValueDictinaryList { get; set; }
    }
}