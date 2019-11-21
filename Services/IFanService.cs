using StarWarsFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Services
{
    public interface IFanService
    {
        StarWarsFanModel AddFan(AddStarWarsFanModel userModel);
        StarWarsFanModel GetMostRecentFan();
        void AddFavoritePlanet(int Id, string URL);
        ListOfFansFavoritePlanets FanFavPlanetUrl(int Id);
        ListOfFansFavoritePlanets DeletePlanetFromFavorites(string Url);
        int CheckIfPlanetIsEntered(int Id, string Url);
    }
}
