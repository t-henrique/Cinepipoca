using System;
using System.Globalization;
using Xamarin.Forms;

namespace Cinepipoca.Components.Converters
{
    public class GenresConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "xas";
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "xas";

            //throw new NotImplementedException();
        }
    }
}
