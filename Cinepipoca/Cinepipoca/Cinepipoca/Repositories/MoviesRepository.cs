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
    public class MoviesRepository : RepositoryConfigInterface<IMoviesRoutes>, IMoviesRepository
    {
        private IMoviesRoutes moviesRoutes;
        public async Task<MovieResults> getUpcommingMovies(int page)
        {
            moviesRoutes = returnRepositoryConfiguration();

            try
            {
                var result = await moviesRoutes.GetUpcomingMovies(1, Config.Apikey);

               return result;

            }
            catch (Exception ex)
            {
                var result = new MovieResults();
                result.statusCode = 500;
                result.statusMessage = $"Aconteceu um erro com a sua solicitação: {ex.Message}";
                return result;
            }


        }
    }
}
