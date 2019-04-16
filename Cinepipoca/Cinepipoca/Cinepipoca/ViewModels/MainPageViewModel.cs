using Cinepipoca.Interfaces;
using Cinepipoca.Models;
using Cinepipoca.ValueObjects;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepipoca.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private ObservableCollection<Movie> _moviesItens;
        public ObservableCollection<Movie> MoviesItens
        {
            get { return _moviesItens; }
            set { SetProperty(ref _moviesItens, value); }
        }

        private ObservableCollection<Genres> _genresDescriptions;
        public ObservableCollection<Genres> GenresDescriptions
        {
            get { return _genresDescriptions; }
            set { SetProperty(ref _genresDescriptions, value); }
        }


        private readonly IMoviesRepository _moviesRepository;
        private readonly IGenresRepository _genresRepository;
        public MainPageViewModel(INavigationService navigationService, IMoviesRepository moviesRepository, IGenresRepository genresRepository)
            : base(navigationService)
        {
            _moviesRepository = moviesRepository;
            _genresRepository = genresRepository;
            Title = "Main Page";

            MoviesItens = new ObservableCollection<Movie>();
            GenresDescriptions = new ObservableCollection<Genres>();
            //test
            // exclude it
            loadBeginingData();
        }

        private async Task loadBeginingData()
        {

            //var y = _genresRepository.getMoviesGenres();
            //if (y.Result != null)
            //{
            //    foreach (var item in y.Result.genres)
            //    {
            //        GenresDescriptions.Add(item);
            //    }
            //}
            var x = await _moviesRepository.getUpcommingMovies(0);
            if (x.results != null)
            {
                foreach (var item in x.results)
                {
                    MoviesItens.Add(item);
                }
            }
        }
    }
}
