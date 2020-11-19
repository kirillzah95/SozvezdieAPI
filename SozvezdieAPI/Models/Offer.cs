using System.Collections.Generic;

namespace SozvezdieAPI.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public string MinPrice { get; set; }
        public Dictionary<string, string> PhotoCard { get; set; }
    }
}
