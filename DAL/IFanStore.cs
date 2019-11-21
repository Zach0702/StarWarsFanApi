using StarWarsFan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.DAL
{
    public interface IFanStore
    {
        bool InsertNewFan(FanDALModel userFan);
        FanDALModel GetMostRecentFan();
        bool InsertFavoritePlanet(FavoritePlanetDALModel favoritePlanet);
        IEnumerable<PlanetDALUrl> SelectAllFavoritePlanetsById(int Id);
        bool DeleteFavoritePlanet(int Id, string Url);
        int CheckIfPlanetIsAlreadyFavorite(int Id, string Url);
    }
}
