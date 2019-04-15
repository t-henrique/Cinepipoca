using Xamarin.Forms;

namespace Cinepipoca.Components
{
    public partial class UpcomingMoviesList : ContentView
    {
        public static readonly BindableProperty FooProperty =
            BindableProperty.Create(
                nameof(Foo),
                typeof(string),
                typeof(UpcomingMoviesList), null);
                

        public UpcomingMoviesList()
        {
            InitializeComponent();
        }

        public string Foo
        {
            get => (string)GetValue(FooProperty);
            set => SetValue(FooProperty, value);
        }
    }
}
