using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace PhapY.Formatter
{
    public class TextIndentConverter1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                string val = value.ToString();
                //value = "                                            " + val.Replace(Environment.NewLine, Environment.NewLine + "                                            ").Trim();
                value = parameter.ToString() + val.Replace(Environment.NewLine, Environment.NewLine + parameter.ToString()).Trim();
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
