using System.Collections;
using System.Collections.Generic;

namespace lab16_brian.Models
{
    public interface IDestinations
    {
        IEnumerable<Destination> Destinations { get; }
    }
}
