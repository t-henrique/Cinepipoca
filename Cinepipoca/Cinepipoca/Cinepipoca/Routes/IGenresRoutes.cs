using Cinepipoca.Dtos;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.Routes
{
    public interface IGenresRoutes
    {
        [Get("/genre/movie/list")]
        Task<GenresResults> GetMovieGenres([AliasAs("api_key")] string apiKey);
    }
}
