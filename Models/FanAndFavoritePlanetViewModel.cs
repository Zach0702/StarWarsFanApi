using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Models
{
    public class FanAndFavoritePlanetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PlanetsResponse> ListOfPlanets { get; set; }
    }
}
