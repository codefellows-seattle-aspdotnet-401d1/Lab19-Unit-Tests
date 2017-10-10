using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public List<string> RequiredItems { get; set; }
    }
}
