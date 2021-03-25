# ivalueconverter

## Overview

> All of the examples below are used in __League of Legends__ [here.](https://github.com/devncore/leagueoflegends/tree/master/Leagueoflegends/Leagueoflegends.Converter/Windows/Converters)

- [Single Converter](#single-converter)
- [Multiple Converter](#multiple-converter)
<br />

## Single Converter
- [BooleanToVisibilityConverter](#booleantovisibilityconverter)
- [BooleanToCollapsedConverter](#booleantocollapsedconverter)
- [EqualsVisibilityConverter](#equalsvisibilityconverter)
- [StringExistsToBooleanConverter](#stringexiststobooleanconverter)
- [WidthPercentageConverter](#widthpercentageconverter)
<br />

### BooleanToVisibilityConverter
`code behind`
```csharp
namespace Leagueoflegends.Windows.Converters
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
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/>
</>
```
<br />

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
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:BooleanToCollapsedConverter x:Key="BooleanToCollapsedConverter"/>
</>
```
<br />

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
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:EqualsVisibilityConverter x:Key="EqualsVisibilityConverter"/>
</>
```
<br />

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
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:StringExistsToBooleanConverter x:Key="StringExistsToBooleanConverter"/>
</>
```
<br />

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
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:WidthPercentageConverter x:Key="WidthPercentageConverter"/>
</>
```
<br />

`ResourceDictionary`
```xaml
 <Style TargetType="{x:Type TextBox}" x:Key="TXT.REPLAY">
 ...
        <Setter Property="Width" Value="{Binding RelativeSource={RelativeSource AncestorType=Grid}, Path=ActualWidth, 
                Converter={StaticResource WidthPercentageConverter}, ConverterParameter=0.8}"/>
 ...
 </Style>
```
<br />

## Multiple Converter
- [MultiValueBooleanConverter](#multivaluebooleanconverter)

### MultiValueBooleanConverter
`code behind`
```csharp
public class MultiValueBooleanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)values[0]==true && !string.IsNullOrWhiteSpace(values[1]?.ToString()));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
```
<br />

`app.xaml`
```xaml
<... xmlns:cvt="Leagueoflegends.Windows.Converters;component">
  <cvt:MultiValueBooleanConverter x:Key="MultiValueBooleanConverter"/>
</>
```
