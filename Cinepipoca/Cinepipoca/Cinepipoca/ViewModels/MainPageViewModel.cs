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
        public MainPageViewModel(INavigationService navigationService, IMoviesRepository moviesRepository)
            : base(navigationService)
        {
            _moviesRepository = moviesRepository;
            Title = "Main Page";

            var x = retornaDados();
        }

        private async Task retornaDados()
        {
            await _moviesRepository.getUpcommingMovies(1);

        }
    }
}
