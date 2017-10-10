using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19UnitTests.Models.Repos
{
    public interface IDestinationRepository
    {
        IEnumerable<Destination> Destination { get; }
    }
}
