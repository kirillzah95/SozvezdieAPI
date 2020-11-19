using System.Collections.Generic;

namespace SozvezdieAPI.Models
{
    public class OfferData : Offer
    {
        public string Header { get; set; }
        public List<string> Route { get; set; }
        public List<Dictionary<string, string>> PhotoAlbum { get; set; }
    }
}
