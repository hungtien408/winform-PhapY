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
using PhapY.App_Code;
using System.Data;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowInBanGiamDinhTinhDuc1.xaml
    /// </summary>
    public partial class WindowInBanGiamDinhTinhDuc1 : Window
    {
        object _DataContext;
        string _MaHoSo, _MaKetLuanTinhDuc;
        DataView dv;
        public WindowInBanGiamDinhTinhDuc1()
        {
            InitializeComponent();
        }
        public WindowInBanGiamDinhTinhDuc1(string MaHoSo, object DataContext)
        {
            InitializeComponent();
            Container.DataContext = DataContext;
            lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
            lblThang.Content = string.Format("{0:MM}", DateTime.Now);
            lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);
            _DataContext = DataContext;
            _MaHoSo = MaHoSo;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Container.DataContext = _DataContext;
                TableKetLuanTinhDuc tblKLTT = new TableKetLuanTinhDuc();
                dv = tblKLTT.get_ketluantinhduc_by_hoso(_MaHoSo);
                Container.DataContext = dv[0];
                _MaKetLuanTinhDuc = dv[0]["MaKetLuanTinhDuc"].ToString();
            }
            catch { }
        }
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var vb = new VisualBrush(Container);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(74, 20, 643, Container.ActualHeight/Container.ActualWidth * 643));
            dc.Close();

            var printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(vis, "Print");
            }
        }
    }
}
