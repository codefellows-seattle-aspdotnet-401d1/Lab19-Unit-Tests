using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19George.Models
{
    public class FakeDestinationRepository : IDestinationRepository
    {
        public IEnumerable<Destination> Destinations => new List<Destination>
        {
            new Destination { City = "Seattle", Country= "United States", Language= "English", Climate= "Temperate" },
            new Destination { City = "London", Country= "England", Language= "English", Climate= "Temperate" },
            new Destination { City = "Sidney", Country= "Ausralia", Language= "English", Climate= "Desert" },
            new Destination { City = "Miami", Country= "United States", Language= "Spanish", Climate= "Tropical" },
            new Destination { City = "Moscow", Country= "Russia", Language= "Russian", Climate= "Arctic" }
        };
    }
}
