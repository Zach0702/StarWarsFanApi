using StarWarsFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Services
{
    public interface IMapPlanet
    {
        Task<PlanetViewModel> MapFromApi();
        Task<PlanetsResponse> ListOfFanFavPlanets(string url);
        Task<PlanetDetailsViewModel> GetPlanetDetails(string url);

    }
}
