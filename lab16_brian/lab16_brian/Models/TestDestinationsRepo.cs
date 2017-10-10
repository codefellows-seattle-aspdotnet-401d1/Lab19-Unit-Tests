using System.Collections.Generic;

namespace lab16_brian.Models
{
    public class TestDestinationsRepo : IDestinations
    {
        public IEnumerable<Destination> Destinations => new List<Destination>
        {
            new Destination {Dest = "Washington", Footware = "Boots", Swimwwear = false},
            new Destination {Dest = "Thailand", Footware = "Sandels", Swimwwear = true},
            new Destination {Dest = "UK", Footware = "Shoes", Swimwwear = false}
        };
    }
}
