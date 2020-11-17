# ivalueconverter
## Single Converter

### BooleanToVisibilityConverter
`code behind`
```csharp
namespance Ncoresoft.Wpfbase.Converters.SingleConverter
{
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
}
```
`app.xaml`
```xaml
<... xmlns:cvt="Ncoresoft.Wpfbase.Converters.SingleConverter;component">
  <cvt:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/>
</>
```

### BooleanToCollapsedConverter
`code behind`
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

## Multiple Converter
