using StarWarsFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Services
{
   public interface IPlanetService
    {
        Task<List</*AllPlanetsApiModel*/ApiPlanet>> GetPlanets();
        Task<Planet> GetPlanetFromUrl(string url);
    }
}
