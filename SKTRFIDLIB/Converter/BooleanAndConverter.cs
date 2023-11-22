using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SKTRFIDLIB.Converter
{
    class BooleanAndConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            foreach (var item in values)
            {
                bool value = (bool)item;

                if (!value)
                {
                    return false;
                }
            }

            return true;
        }

        /// <exception cref="NotSupportedException">BooleanAndConverter is a OneWay converter.</exception>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("BooleanAndConverter is a OneWay converter.");
        }
    }
}
