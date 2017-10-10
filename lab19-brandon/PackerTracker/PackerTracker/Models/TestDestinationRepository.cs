using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class TestDestinationRepository : IRepository
    {
        public IEnumerable<Destination> Destination => new List<Destination>
        {
            new Destination{LocationName = "Hawaii", Country = "USA", RequiredItems = new List<string>{"Shorts", "Sandals", "Beach Towels", "Sunscreen"}},
            new Destination{LocationName = "Dublin", Country = "Ireland", RequiredItems = new List<string>{"Raincoat", "Identification", "Castle Guidebook"}},
            new Destination{LocationName = "Tokyo", Country = "Japan", RequiredItems = new List<string>{"Clean White Socks", "Umbrella", "Adventurous Appetite"}}
        };
    }
}
