using Cinepipoca.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.Interfaces
{
    public interface IMoviesRepository
    {
        Task<MovieResults> getUpcommingMovies(int page);
    }
}
