﻿using Prism;
using Prism.Ioc;
using Cinepipoca.ViewModels;
using Cinepipoca.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Cinepipoca.Interfaces;
using Cinepipoca.Repositories;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Cinepipoca
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            InitServices(containerRegistry);
        }

        private void InitServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMoviesRepository, MoviesRepository>();
            containerRegistry.RegisterSingleton<IGenresRepository, GenresRepository>();
            containerRegistry.RegisterInstance<IPopupNavigation>(PopupNavigation.Instance);
            
        }
    }
}
