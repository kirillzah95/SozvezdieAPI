using System.Collections.Generic;

namespace SozvezdieAPI.Models
{
    public class OfferData
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public List<string> Route { get; set; }
        public string Description { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public string MinPrice { get; set; }
        public List<Dictionary<string, string>> PhotoAlbum { get; set; }
    }
}