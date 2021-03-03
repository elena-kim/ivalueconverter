# ivalueconverter
## Single Converter

### BooleanToVisibilityConverter
`code behind`
```csharp
namespace Ncoresoft.Wpfbase.Converters.SingleConverter
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
`app.xaml`
```xaml
<... xmlns:cvt="Ncoresoft.Wpfbase.Converters.SingleConverter;component">
  <cvt:BooleanToCollapsedConverter x:Key="BooleanToCollapsedConverter"/>
</>
```

### EqualsVisibilityConverter
`code behind`
```csharp
public class EqualsVisibilityConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
      return value.Equals(parameter) ? Visibility.Visible : Visibility.Collapsed;
  }
  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
      throw new NotImplementedException();
  }
}
```
`app.xaml`
```xaml
<... xmlns:cvt="Ncoresoft.Wpfbase.Converters.SingleConverter;component">
  <cvt:EqualsVisibilityConverter x:Key="EqualsVisibilityConverter"/>
</>
```

### StringExistsToBooleanConverter
`code behind`
```csharp
public class StringExistsToBooleanConverter : IValueConverter
{
  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
  {
      return !string.IsNullOrWhiteSpace(value?.ToString());
  }
  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
      throw new NotImplementedException();
  }
}
```
`app.xaml`
```xaml
<... xmlns:cvt="Ncoresoft.Wpfbase.Converters.SingleConverter;component">
  <cvt:StringExistsToBooleanConverter x:Key="StringExistsToBooleanConverter"/>
</>
```

### WidthPercentageConverter
`code behind`
```csharp
public class WidthPercentageConverter : MarkupExtension, IValueConverter
    {
        private static WidthPercentageConverter _instance;

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new WidthPercentageConverter());
        }
    }
```
`app.xaml`
```xaml
<... xmlns:cvt="Ncoresoft.Wpfbase.Converters.SingleConverter;component">
  <cvt:WidthPercentageConverter x:Key="WidthPercentageConverter"/>
</>
```
`ResourceDictionary`
```xaml
 <Style TargetType="{x:Type TextBox}" x:Key="CTRL.TXT.REPLAY.LOCATION">
 ...
        <Setter Property="Width" Value="{Binding RelativeSource={RelativeSource AncestorType=Grid}, Path=ActualWidth, 
                Converter={StaticResource WidthPercentageConverter}, ConverterParameter=0.8}"/>
 ...
 </Style>

```
## Multiple Converter
TBD..
