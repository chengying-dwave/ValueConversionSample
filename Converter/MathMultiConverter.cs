using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ValueConversionSample.Converter;

internal class MathMultiConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
