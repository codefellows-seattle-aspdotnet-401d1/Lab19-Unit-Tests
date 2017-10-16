using System.Collections.Generic;

namespace Lab19George.Models
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destinations { get; }
    }
}
