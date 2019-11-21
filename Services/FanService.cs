using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsFan.DAL;
using StarWarsFan.Models;

namespace StarWarsFan.Services
{
    public class FanService : IFanService
    {
        private readonly IFanStore _fanStore;

        public FanService(IFanStore fanStore)
        {
            _fanStore = fanStore;
        }
        public StarWarsFanModel AddFan(AddStarWarsFanModel userModel)
        {
            var dalModel = new FanDALModel();
            dalModel.Name = userModel.Name;
            _fanStore.InsertNewFan(dalModel);

            var fanModel = new StarWarsFanModel();
            fanModel.Name = userModel.Name;
            return fanModel;
        }

        public void AddFavoritePlanet(int Id, string URL)
        {
            var planetDALModel = new FavoritePlanetDALModel();
            planetDALModel.Id = Id;
            planetDALModel.Url = URL;
            _fanStore.InsertFavoritePlanet(planetDALModel);
        }

        public int CheckIfPlanetIsEntered(int Id, string Url)
        {
            var result = _fanStore.CheckIfPlanetIsAlreadyFavorite(Id, Url);
            return result;
        }

        public ListOfFansFavoritePlanets DeletePlanetFromFavorites(string Url)
        {
            var dalModel = _fanStore.GetMostRecentFan();
            _fanStore.DeleteFavoritePlanet(dalModel.Id, Url);

            var dalList = _fanStore.SelectAllFavoritePlanetsById(dalModel.Id);
            var planetUrlList = new List<PlanetUrl>();
            foreach (var url in dalList)
            {
                var planetUrl = new PlanetUrl();
                planetUrl.Url = url.Url;
                planetUrlList.Add(planetUrl);
            }
            var listOfAllPlanetUrl = new ListOfFansFavoritePlanets();
            listOfAllPlanetUrl.FanList = planetUrlList;
            return listOfAllPlanetUrl;
        }

        public ListOfFansFavoritePlanets FanFavPlanetUrl(int Id)
        {
            var dalList = _fanStore.SelectAllFavoritePlanetsById(Id);

            var planetUrlList = new List<PlanetUrl>();
            foreach (var url in dalList)
            {
                var planetUrl = new PlanetUrl();
                planetUrl.Url = url.Url;
                planetUrlList.Add(planetUrl);
            }
            var listOfAllPlanetUrl = new ListOfFansFavoritePlanets();
            listOfAllPlanetUrl.FanList = planetUrlList;
            return listOfAllPlanetUrl;
        }

        public StarWarsFanModel GetMostRecentFan()
        {
            var dalModel = _fanStore.GetMostRecentFan();
            var fanModel = new StarWarsFanModel();
            fanModel.Id = dalModel.Id;
            fanModel.Name = dalModel.Name;

            return fanModel;
        }
    }
}
