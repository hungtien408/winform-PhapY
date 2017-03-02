using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace PhapY.Formatter
{
    public class FormatVisibilityVinhVien : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                int num;
                bool isNum = Int32.TryParse(value.ToString(), out num);
                if (string.IsNullOrEmpty(value.ToString().Trim()))
                {
                    return "Collapsed";
                }
                else if(isNum)
                {
                    if (Int32.Parse(value.ToString()) == 0)
                    {
                        return "Collapsed";
                    }
                    else
                    {
                        return "Visible";
                    }
                }
                else
                {
                    return "Visible";
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
