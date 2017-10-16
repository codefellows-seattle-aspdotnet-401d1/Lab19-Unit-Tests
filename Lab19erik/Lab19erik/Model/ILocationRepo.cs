using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19erik.Model
{
    public interface ILocationRepo
    {
        IEnumerable<Location> Location { get; }
    }
}
