using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWarsFan.Models;
using Dapper;
using System.Data.SqlClient;

namespace StarWarsFan.DAL
{
    public class FanStore : IFanStore
    {
        private readonly Database _config;

        public FanStore(StarWarsConfig config)
        {
            _config = config.Database;
        }

        public int CheckIfPlanetIsAlreadyFavorite(int Id, string Url)
        {
            var sql = @"SELECT Id FROM StarWarsFanFavPlanets WHERE Id = @Id AND Url Like @Url ";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, new { Id = Id, Url = $"%{Url}%" });

                return result;         
            }
        }

        public bool DeleteFavoritePlanet(int Id, string url)
        {
            var sql = @"DELETE FROM StarWarsFanFavPlanets WHERE Id = @Id AND Url Like @Url ";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, new { Id = Id, Url = $"%{url}%" });

                return true;
            }
        }
        public FanDALModel GetMostRecentFan()
        {
            var sql = @"Select top 1 Id,Name From Fan Order By id Desc"; //might need @near idname

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<FanDALModel>(sql);

                return result;
            }
        }

        public bool InsertFavoritePlanet(FavoritePlanetDALModel favoritePlanet)
        {
            var sql = $@"INSERT INTO StarWarsFanFavPlanets (Id, Url) VALUES(@{nameof(favoritePlanet.Id)}
              ,@{nameof(favoritePlanet.Url)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, favoritePlanet);
                return true;
            }
        }

        public bool InsertNewFan(FanDALModel userFan)
        {
            var sql = $@"INSERT INTO Fan (Name) Values(@{nameof(userFan.Name)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, userFan);
                return true;
            }
        }

        public IEnumerable<PlanetDALUrl> SelectAllFavoritePlanetsById(int Id)
        {
            var sql = @"SELECT (Url) From StarWarsFanFavPlanets WHERE Id = @Id";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<PlanetDALUrl>(sql, new { Id = Id });

                return result;
            }
        }

        
    }
  }

