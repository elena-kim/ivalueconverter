# ivalueconverter

## Single Converter

BooleanToVisibilityConverter
```csharp
public class BooleanToVisibilityConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
      return value.Equals(true) ? Visibility.Visible : Visibility.Collapsed;
  }
  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
      throw new NotImplementedException();
  }
}
```
BooleanToCollapsedConverter
```csharp
public class BooleanToCollapsedConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
      return value.Equals(true) ? Visibility.Collapsed : Visibility.Visible;
  }
  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
      throw new NotImplementedException();
  }
}
```
