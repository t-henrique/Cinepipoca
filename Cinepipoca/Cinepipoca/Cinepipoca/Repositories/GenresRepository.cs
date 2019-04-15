using Cinepipoca.Configurations;
using Cinepipoca.Dtos;
using Cinepipoca.Interfaces;
using Cinepipoca.Routes;
using Cinepipoca.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.Repositories
{
    public class GenresRepository : RepositoryConfigInterface<IGenresRoutes>, IGenresRepository
    {
        IGenresRoutes genresRoutes;
        public async Task<GenresResults> getMoviesGenres()
        {
            genresRoutes = returnRepositoryConfiguration();

            
            try
            {
                var result = await genresRoutes.GetMovieGenres(Config.Apikey);

                return result;

            }
            catch (Exception ex)
            {
                var result = new GenresResults();
                result.statusCode = 500;
                result.statusMessage = $"Aconteceu um erro com a sua solicitação: {ex.Message}";
                return result;
            }
        }

    }
}