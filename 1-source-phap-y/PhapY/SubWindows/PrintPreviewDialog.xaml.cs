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
    /// Interaction logic for PrintPreviewDialog.xaml
    /// </summary>
    public partial class PrintPreviewDialog : Window
    {
        public PrintPreviewDialog()
        {
            InitializeComponent();
        }
        public PrintPreviewDialog(VisualBrush Child)
        {
            InitializeComponent();
            Container.Fill = Child;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            printDlg.UserPageRangeEnabled = true;
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(Container, "Print");
            }
        }
    }
}
