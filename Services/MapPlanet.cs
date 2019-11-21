using StarWarsFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Services
{
    public class MapPlanet : IMapPlanet
    {
        private readonly IPlanetService _planetService;

        public MapPlanet(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        public async Task<PlanetDetailsViewModel> GetPlanetDetails(string url)
        {
            var apiPlanet = await _planetService.GetPlanetFromUrl(url);
            var planetDetails = new PlanetDetailsViewModel();
            planetDetails.name = apiPlanet.name;
            planetDetails.climate = apiPlanet.climate;
            planetDetails.diameter = apiPlanet.diameter;
            planetDetails.films = apiPlanet.films;
            planetDetails.gravity = apiPlanet.gravity;
            planetDetails.orbital_period = apiPlanet.orbital_period;
            planetDetails.population = apiPlanet.population;
            planetDetails.residents = apiPlanet.residents;
            planetDetails.rotation_period = apiPlanet.rotation_period;
            planetDetails.surface_water = apiPlanet.surface_water;
            planetDetails.terrain = apiPlanet.terrain;

            return planetDetails;
        }

        public async Task<PlanetsResponse> ListOfFanFavPlanets(string url)
        {
            var planet = await _planetService.GetPlanetFromUrl(url);
            var planetName = new PlanetsResponse();
            planetName.Name = planet.name;
            planetName.Url = planet.url;
            return planetName;
        }
        public async Task<PlanetViewModel> MapFromApi()
        {
            var planetList = await _planetService.GetPlanets();

            var planets = new List<PlanetsResponse>();

            foreach (var planet in planetList/*.results*/)
            {

                var planetName = new PlanetsResponse();
                planetName.Name = planet.name;
                planetName.Url = planet.url;
                planets.Add(planetName);

            }

            var planetNameViewModel = new PlanetViewModel();

            planetNameViewModel.ListOfPlanets = planets;

            return planetNameViewModel;
        }
    }
}
