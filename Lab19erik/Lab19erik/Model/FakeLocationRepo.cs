using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19erik.Model
{
    public class FakeLocationRepo : ILocationRepo
    {
        public IEnumerable<Location> Location => new List<Location>
        {
            new Location {Name = "Hawaii", Latitude = 19.896766, Longitede = -155.582782, WeatherType = "Tropical"},
            new Location {Name ="Alaska", Latitude = 61.174235, Longitede = -149.982012, WeatherType = " Arctic"},
            new Location {Name = "Texas", Latitude = 31.968599, Longitede = -99.901813, WeatherType = "Maritime"},
            new Location {Name = "Florida", Latitude = 27.664827, Longitede = -81.515754, WeatherType = "Tropical"}
        };
    }
}
