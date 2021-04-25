### About us

> &nbsp; :adult: __James Lee__ &nbsp;&nbsp; [Github](https://github.com/devncore-james) &nbsp;&nbsp; james.lee@devncore.org  
> &nbsp; :woman: __Elena Kim__ &nbsp;&nbsp; [Github](https://github.com/devncore-elena) &nbsp;&nbsp; elena.kim@devncore.org

We are very ordinary developers, so we need to communicate with you.   
You can always share information with us and we are looking forward to it.  

##### _Open Source &nbsp; https://github.com/devncore/devncore   &nbsp;&nbsp;   Official Website &nbsp; https://devncore.org_ 

### License Policy
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
[![GPLv3 license](https://img.shields.io/badge/License-GPLv3-blue.svg)](http://perso.crans.org/besson/LICENSE.html)

***

## IValueConverter

|Namespace|Assembly|
|:--------|:-------|
|`System.Windows.Data`|`PresentationFramework.dll`|

Value converters provides a way to apply custom logic to a [binding](https://github.com/devncore/wpf-xaml-binding).  
When source object type and target object type are different, value converters act like middlemen.  
Converter class must implement **IValueConverter** interface, which consists of two methods, `Convert()` and `ConvertBack()`.

_**Convert** method gets called when source updates target object._
```c#
public object Convert (object value, Type targetType, object parameter, CultureInfo culture);

// parameters:
//   value: The value produced by the binding source.
//   targetType: The type of the binding target property.
//   parameter: The converter parameter to use.
//   culture: The culture to use in the converter.
// return:
//   A converted value. If the method returns null, the valid null value is used.
```  

_**ConvertBack** method gets called when target updates source object._
```c#
public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture);

// parameters:
//   value: The value that is produced by the binding target.
//   targetType: The type to convert to.
//   parameter: The converter parameter to use.
//   culture: The culture to use in the converter.
// return:
//   A converted value. If the method returns null, the valid null value is used.
```  
***

## Sample
TBD..

***

## Reference
[:bookmark_tabs:](https://www.codeproject.com/Tips/868163/IValueConverter-Example-and-Usage-in-WPF) **CODE PROJECT** &nbsp; <ins>IValueConverter Example and Usage in WPF</ins>  
[:bookmark_tabs:](https://docs.microsoft.com/en-ca/dotnet/api/system.windows.data.ivalueconverter?view=net-5.0) **Microsoft Docs** &nbsp; <ins>IValueConverter Interface</ins>  
[:bookmark_tabs:](https://www.wpf-tutorial.com/data-binding/value-conversion-with-ivalueconverter/) **WPF Tutorial** &nbsp; <ins>Value conversion with IValueConverter</ins>
