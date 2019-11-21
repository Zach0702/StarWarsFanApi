using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsFan.Models;
using StarWarsFan.Services;

namespace StarWarsFan.Controllers
{
    public class StarWarsController : Controller
    {
        private readonly IFanService _fanService;
        private readonly IMapPlanet _mapPlanet;

        public StarWarsController(IFanService fanService, IMapPlanet mapPlanet)
        {
            _fanService = fanService;
            _mapPlanet = mapPlanet;
        }
       public IActionResult AddFan()
        {
            return View();
        }
        
        public IActionResult AddFavoriteStarWarsItems(AddStarWarsFanModel userModel)
        {
            var fanResult = _fanService.AddFan(userModel);
            return View();
        }

        public async Task<IActionResult> ViewAllPlanets()
        {
            var result = new PlanetViewModel();
            result = await _mapPlanet.MapFromApi();

            return View(result);
        }

        public async Task<IActionResult> ViewFanNameAndFavoritePlanet(string Url)
        {
            var fan = _fanService.GetMostRecentFan();

            var result = _fanService.CheckIfPlanetIsEntered(fan.Id, Url);
            if (result >= 1)
            {
                return View("Error", new ErrorViewModel
                { Message = "ERROR Planet is already saved as one of your favorties" });
            }


            _fanService.AddFavoritePlanet(fan.Id, Url);
            var listofUrl = _fanService.FanFavPlanetUrl(fan.Id);

            var listOfPlanetNames = new List<PlanetsResponse>();

            foreach (var url in listofUrl.FanList) //validate add same planet here
            {
                var planetName = new PlanetsResponse();
                planetName = await _mapPlanet.ListOfFanFavPlanets(url.Url);
                listOfPlanetNames.Add(planetName);
            }
           var listOfPlanetNamesAndFanName = new FanAndFavoritePlanetViewModel();

            listOfPlanetNamesAndFanName.ListOfPlanets = listOfPlanetNames;
            listOfPlanetNamesAndFanName.Name = fan.Name;

            return View(listOfPlanetNamesAndFanName);
        }

        public async Task<IActionResult> ViewPlanetDetails(string Url)
        {
            var planetDetails = await _mapPlanet.GetPlanetDetails(Url);
            return View(planetDetails);
        }

        public async Task<IActionResult> DeleteResults(string Url)
        {
            var result =  _fanService.DeletePlanetFromFavorites(Url);
            var fan = _fanService.GetMostRecentFan();
            var listOfPlanetNames = new List<PlanetsResponse>();
            foreach (var url in result.FanList) //validate add same planet here
            {
                var planetName = new PlanetsResponse();
                planetName = await _mapPlanet.ListOfFanFavPlanets(url.Url);
                listOfPlanetNames.Add(planetName);
            }
            var listOfPlanetNamesAndFanName = new FanAndFavoritePlanetViewModel();

            listOfPlanetNamesAndFanName.ListOfPlanets = listOfPlanetNames;
            listOfPlanetNamesAndFanName.Name = fan.Name;
            return View("ViewFanNameAndFavoritePlanet", listOfPlanetNamesAndFanName);
        }
    }
}