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

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for InBienNhan.xaml
    /// </summary>
    public partial class InBienNhan : Window
    {
        public InBienNhan()
        {
            InitializeComponent();
        }

        public InBienNhan(object DataContext)
        {
            InitializeComponent();
            Container.DataContext = DataContext;
            lblNgay.Content = DateTime.Now.Day;
            lblThang.Content = DateTime.Now.Month;
            lblNam.Content = DateTime.Now.Year;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var vb = new VisualBrush(Container);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(40, 20, Container.ActualWidth -40, Container.ActualHeight-20));
            dc.Close();

            var printDlg = new PrintDialog();
            printDlg.UserPageRangeEnabled = true;
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(vis, "Print");
            }
        }
    }
    
}
