using System;
using System.Collections.Generic;
using System.Text;
using Cinepipoca.Models;
using Prism.Navigation;

namespace Cinepipoca.ViewModels
{
    public class MovieDetailsPopupPageViewModel : ViewModelBase
    {

        public MovieDetailsPopupPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            movies = movies;

        }

        private Movie _movie;
        public Movie movies
        {
            get { return _movie; }
            set
            {
                SetProperty(ref _movie, value);
            }

            //OnPropertyChanged(nameof(Movie));
        }
    }
}
