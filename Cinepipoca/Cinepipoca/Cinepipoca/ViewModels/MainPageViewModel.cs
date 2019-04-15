using Cinepipoca.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private readonly IMoviesRepository _moviesRepository;
        private readonly IGenresRepository _genresRepository;
        public MainPageViewModel(INavigationService navigationService, IMoviesRepository moviesRepository, IGenresRepository genresRepository)
            : base(navigationService)
        {
            _moviesRepository = moviesRepository;
            _genresRepository = genresRepository;
            Title = "Main Page";


            //test
            // exclude it
            var x = retornaDados();
        }

        private async Task retornaDados()
        {
            await _moviesRepository.getUpcommingMovies(0);
            //await _genresRepository.getMoviesGenres();

        }
    }
}
