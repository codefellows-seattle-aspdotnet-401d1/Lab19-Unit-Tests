using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19Tom.Models
{
    public class DummyDestinationsRepository : IDestinationsRepository
    {
        public IEnumerable<Destinations> Destinations => new List<Destinations>
        {
            new Destinations {Destination = "Honolulu", Tops = "Tees, tanks, hawaiian shirts", Bottoms = "Shorts and swimwear", Footwear = "Flip-flops", Sunscreen = "Definitely bring sunscreen!"},
            new Destinations {Destination = "London", Tops = "Raincoats", Bottoms = "Pants", Footwear = "Shoes", Sunscreen = "No suncreen needed"},
            new Destinations {Destination = "Grindavík", Tops = "Jackets", Bottoms = "Pants and swimwear (for the spas!)", Footwear = "Boots or shoes", Sunscreen = "No suncreen needed"},
            new Destinations {Destination = "Tokyo", Tops = "Cosplay top", Bottoms = "Cosplay pants", Footwear = "Cosplay shoes", Sunscreen = "No suncreen needed"}
        };
    }
}
