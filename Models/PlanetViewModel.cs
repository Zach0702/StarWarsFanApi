﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Models
{
    public class PlanetViewModel
    {
        public IEnumerable<PlanetsResponse> ListOfPlanets { get; set; }
    }
}
