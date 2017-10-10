using System.Collections.Generic;

namespace PackerTracker.Models
{
    public interface IRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
