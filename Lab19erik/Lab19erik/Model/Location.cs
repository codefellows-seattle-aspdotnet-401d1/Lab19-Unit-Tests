using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19erik.Model
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitede { get; set; }
        public string WeatherType { get; set; }
    }
}
