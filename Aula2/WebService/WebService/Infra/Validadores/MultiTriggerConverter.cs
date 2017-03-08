using System;
using System.Globalization;
using Xamarin.Forms;

namespace WebService.Infra.Validadores
{
    public class MultiTriggerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if ((int)value < 6)
                return true;    // data has been entered
            else
                return false;   // input is empty
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
