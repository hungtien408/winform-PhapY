using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace PhapY.Formatter
{


    public class FormatVisibilityPhetDichAmDao : IMultiValueConverter
    {
        #region IMultiValueConverter Members

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string returnVal = "Auto";
            try
            {
                if (values[0].ToString() == "True" && values[1].ToString() == "True")
                {
                    returnVal = "0";
                }
                else
                {
                    if (string.IsNullOrEmpty(values[2].ToString()) && string.IsNullOrEmpty(values[3].ToString()))
                    {
                        returnVal = "0";
                    }
                }
            }
            catch
            {
            }
            return 0;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
