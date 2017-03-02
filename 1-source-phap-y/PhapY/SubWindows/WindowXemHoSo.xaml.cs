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
using System.Windows.Shapes;
using System.Globalization;
using System.Threading;
using PhapY.App_Code;
using System.IO;
using PhapY.uc;
using System.Data;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowXemHoSo.xaml
    /// </summary>
    public partial class WindowXemHoSo : Window
    {
        public WindowXemHoSo()
        {
            InitializeComponent();
        }
        public WindowXemHoSo(object DataContext)
        {
            InitializeComponent();
            Container.DataContext = DataContext;
        }
        private void print()
        {
            if (this.WindowState != WindowState.Normal)
            {
                this.WindowState = WindowState.Normal;
            }
            this.Width = 760;
            PrintDialog printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(this, "Print");
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        

    }
}
