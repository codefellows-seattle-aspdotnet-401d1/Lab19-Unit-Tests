﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19Tom.Models
{
    public interface IDestinationsRepository
    {
        IEnumerable<Destinations> Destinations { get; }
    }
}
