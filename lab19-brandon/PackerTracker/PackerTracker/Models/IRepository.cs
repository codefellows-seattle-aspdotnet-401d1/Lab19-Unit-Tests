using System.Collections.Generic;

namespace PackerTracker.Models
{
    interface IRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
