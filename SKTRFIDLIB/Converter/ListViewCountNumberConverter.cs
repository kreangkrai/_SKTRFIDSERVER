using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace SKTRFIDLIB.Converter
{
    public class ListViewCountNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ListViewItem item)
            {
                if (ItemsControl.ItemsControlFromItemContainer(item) is ListView listView)
                {
                    int count = listView.Items.Count;
                    int index = listView.ItemContainerGenerator.IndexFromContainer(item);

                    int result = 0;
                    if (index == 0 && count > 0)
                    {
                        result = count;
                    }
                    else
                    {
                        result = count - index;
                    }

                    return result.ToString();
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
