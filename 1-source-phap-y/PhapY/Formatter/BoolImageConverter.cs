using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace PhapY.Formatter
{
    public class BoolImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (bool.Parse(value.ToString()))
                {
                    return "/PhapY;component/Images/img-check.gif";
                }
                else
                {
                    return "/PhapY;component/Images/img-no-check.gif";
                }
            }
            catch
            {
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
