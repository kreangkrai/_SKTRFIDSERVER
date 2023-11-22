using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SKTRFIDLIB.Converter
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public BooleanToVisibilityConverter() { }

        #endregion Constructors

        #region Properties

        public Visibility TrueState { get; set; }
        public Visibility FalseState { get; set; }

        #endregion Properties

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool bValue = (bool)value;

            if (bValue)
            {
                return TrueState;
            }
            return FalseState;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;

            if (visibility == TrueState)
            {
                return true;
            }
            else if (visibility == FalseState)
            {
                return false;
            }
            return null;
        }

        #endregion IValueConverter Members
    }
}
