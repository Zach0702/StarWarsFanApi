using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Models
{
    public class ListOfFansFavoritePlanets
    {
        public IEnumerable<PlanetUrl> FanList { get; set; }
    }
}
