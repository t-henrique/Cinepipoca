using Cinepipoca.Dtos;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.Routes
{
    public interface IMoviesRoutes 
    {
        [Get("/movie/upcoming")]
        Task<MovieResults> GetUpcomingMovies(int page, [AliasAs("api_key")] string apiKey);
    }
}
