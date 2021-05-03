using System;
using System.Globalization;
using System.Windows.Data;

namespace IValueConverterSample.Converters
{
    public class MultiValueBooleanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)values[0] == true && !string.IsNullOrWhiteSpace(values[1]?.ToString()));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
