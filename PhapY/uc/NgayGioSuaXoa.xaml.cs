using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PhapY.App_Code;
using System.Globalization;
using System.Threading;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for NgayGioSuaXoa.xaml
    /// </summary>
    public partial class NgayGioSuaXoa : UserControl
    {
        public NgayGioSuaXoa()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.ShortTimePattern = "hh:mm tt";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            var tbl = new TableNgayGioSuaXoa();
            dataGrid1.ItemsSource = tbl.get_ngaygiosuaxoa();
        }
    }
}
