using Cinepipoca.Configurations;
using Cinepipoca.Dtos;
using Cinepipoca.Interfaces;
using Cinepipoca.Models;
using Cinepipoca.Routes;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private IMoviesRoutes moviesRoutes;
        public async Task<MovieResults> getUpcommingMovies(int page)
        {
             moviesRoutes = RestService.For<IMoviesRoutes>(Config.UrlBase,
                new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        }
                    )
                }
            );

            try
            {
                var result = await moviesRoutes.GetUpcomingMovies(1, Config.Apikey);

                return new MovieResults();

            }
            catch (Exception ex)
            {

                throw new    NotImplementedException();
            }


        }
    }
}
