using Cinepipoca.Components;
using Cinepipoca.Interfaces;
using Cinepipoca.Models;
using Cinepipoca.ValueObjects;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.Extended;

namespace Cinepipoca.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private ObservableCollection<Movie> _moviesUpcomingItens;
        public ObservableCollection<Movie> MoviesUpcomingItens
        {
            get { return _moviesUpcomingItens; }
            set { SetProperty(ref _moviesUpcomingItens, value); }
        }

        public InfiniteScrollCollection<Movie> _movies;
        public InfiniteScrollCollection<Movie> Movies
        {
            get => _movies;
            set => _movies = value;
        }

        private ObservableCollection<Genres> _genresDescriptions;
        public ObservableCollection<Genres> GenresDescriptions
        {
            get { return _genresDescriptions; }
            set { SetProperty(ref _genresDescriptions, value); }
        }

        private int pageCount = 1;

        private readonly IMoviesRepository _moviesRepository;
        private readonly IGenresRepository _genresRepository;
        private readonly IPopupNavigation _popupNavigation;


        public ICommand MovieItemSelectedCommand
        {
            get;
            set;
        }

        public event EventHandler SelectedMovie;

        public MainPageViewModel(INavigationService navigationService, 
            IMoviesRepository moviesRepository, 
            IGenresRepository genresRepository, 
            IPopupNavigation popupNavigation): base(navigationService)
        {
            _moviesRepository = moviesRepository;
            _genresRepository = genresRepository;
            _popupNavigation = popupNavigation;

            MovieItemSelectedCommand = new DelegateCommand<Movie>(ShowDetailedMovie);

            Title = "CinePipoca";

            MoviesUpcomingItens = new ObservableCollection<Movie>();
            GenresDescriptions = new ObservableCollection<Genres>();

            retrieveData();
        }

        private async void ShowDetailedMovie(Movie movie)
        {
           //var vb = new MovieDetailsPopupPageViewModel();
            //vb.Movie = movie;
            await _popupNavigation.PushAsync(new MovieDetailsPopupPage(movie));
        }

        private async void retrieveData()
        {
            //await loadBeginingData();

            await loadMovies();
        }

        private async Task loadBeginingData()
        {
            
            var x = await _moviesRepository.getUpcommingMovies(pageCount);
            if (x.results != null)
            {
                foreach (var item in x.results)
                {
                    MoviesUpcomingItens.Add(item);
                }
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        private async Task loadMovies()
        {
            Movies = new InfiniteScrollCollection<Movie>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;
                    pageCount += 1;
                    var items = await _moviesRepository.getUpcommingMovies(pageCount);
                    IsBusy = false;
                    return items.results;
                },
                OnCanLoadMore = () => Movies.Count < 220
            };
            DownloadDataAsync();
        }
        private async Task DownloadDataAsync()
        {
            var x = await _moviesRepository.getUpcommingMovies(pageCount);
            if (x.results != null)
            {
                Movies.AddRange(x.results);
            }
        }
    }
}
