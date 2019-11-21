using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarWarsFan.Models;

namespace StarWarsFan.Services
{
    public class PlanetService : IPlanetService
    {
        public async Task<Planet> GetPlanetFromUrl(string url)
        {
            string baseAddress = url.Substring(0, 16);
            string otherHalf = url.Substring(url.IndexOf('o') + 1);

            using (var httpClient = new HttpClient { BaseAddress = new Uri(baseAddress) })
            {

                var json = await httpClient.GetStringAsync(otherHalf);


                return JsonConvert.DeserializeObject<Planet>(json);

                
            }
        }

        public async Task<List</*AllPlanetsApiModel*/ApiPlanet>> GetPlanets()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.co") })
            {
                var planetsList = new List<ApiPlanet>();
                var isPageNull = false;
                var pageTracker = 1;
                while (!isPageNull)
                {
                    //only need this and next one for assessment
                    var json = await httpClient.GetStringAsync($"/api/planets/?page={pageTracker}");

                    //you would return JsonConvert.DeserializeObject instead here 
                    var AllOfThePlanetsApiModel = JsonConvert.DeserializeObject<AllPlanetsApiModel>(json);

                    if (AllOfThePlanetsApiModel.next != null)
                    {
                       planetsList.AddRange(AllOfThePlanetsApiModel.results);
                    }
                    else
                     {
                        planetsList.AddRange(AllOfThePlanetsApiModel.results);
                        isPageNull = true;
                     }
                    pageTracker++;
                }
                return planetsList;
            }
        }
    }
}
