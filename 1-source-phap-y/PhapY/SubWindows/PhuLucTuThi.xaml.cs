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

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for PhuLucTuThi.xaml
    /// </summary>
    public partial class PhuLucTuThi : Window
    {
        string _MaHoSo;
        public PhuLucTuThi(string MaHoSo,string SoHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            tblSoHoSo.Text = SoHoSo;
            var tblPLTT = new TablePhuLucTuThi();
            Container.DataContext = tblPLTT.get_phuluctuthi(MaHoSo);
            lblCurrentDate.Content = string.Format("{0:dd}", DateTime.Now);
            lblCurrentMonth.Content = string.Format("{0:MM}", DateTime.Now);
            lblCurrentYear.Content = string.Format("{0:yyyy}", DateTime.Now);
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role3)
            {
                btnUpdate.Visibility = Visibility.Collapsed;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string MaHoSo = _MaHoSo;
            string BanGiamDinhYPhapTuThi = chkBanGiamDinhYPhapTuThi.IsChecked.Value.ToString();
            string BanKetLuanTuThi = chkBanKetLuanTuThi.IsChecked.Value.ToString();
            string QuyetDinhTrungCauGiamDinh = chkQuyetDinhTrungCauGiamDinh.IsChecked.Value.ToString();
            string GiayBaoTu = chkGiayBaoTu.IsChecked.Value.ToString();
            string GiayUopXac = chkGiayUopXac.IsChecked.Value.ToString();
            string CongHam = chkCongHam.IsChecked.Value.ToString();
            string HoChieu = chkHoChieu.IsChecked.Value.ToString();
            string SoDoPhacHoaNguoiBiNan = chkSoDoPhacHoaNguoiBiNan.IsChecked.Value.ToString();
            string XetNghiemNongDoRuou = chkXetNghiemNongDoRuou.IsChecked.Value.ToString();
            string XetNghiemMorPhin = chkXetNghiemMorPhin.IsChecked.Value.ToString();
            string XetNghiemSinhHoa = chkXetNghiemSinhHoa.IsChecked.Value.ToString();
            string XetNghiemHIV = chkXetNghiemHIV.IsChecked.Value.ToString();
            string PhieuXetNghiemGPB = chkPhieuXetNghiemGPB.IsChecked.Value.ToString();
            string BienBanXemXetDauVetCoThe = chkBienBanXemXetDauVetCoThe.IsChecked.Value.ToString();
            string BanKetLuanGiamDinhPhapYVeHoaPhap = chkBanKetLuanGiamDinhPhapYVeHoaPhap.IsChecked.Value.ToString();
            string Khac = chkKhac.IsChecked.Value.ToString();
            string NoiDungKhac = txtNoiDungKhac.Text;
            string TongCong = txtTongCong.Text;
            var tblPLTT = new TablePhuLucTuThi();
            tblPLTT.update_phuluctuthi(
                    MaHoSo,
	                BanGiamDinhYPhapTuThi,
	                BanKetLuanTuThi,
	                QuyetDinhTrungCauGiamDinh,
	                GiayBaoTu,
	                GiayUopXac,
	                CongHam,
	                HoChieu,
	                SoDoPhacHoaNguoiBiNan,
	                XetNghiemNongDoRuou,
	                XetNghiemMorPhin,
	                XetNghiemSinhHoa,
	                XetNghiemHIV,
	                PhieuXetNghiemGPB,
	                BienBanXemXetDauVetCoThe,
	                BanKetLuanGiamDinhPhapYVeHoaPhap,
	                Khac,
	                NoiDungKhac,
	                TongCong
                );
            MessageBox.Show("Cập nhật thành công.");
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            //var vb = new VisualBrush(Container);
            //vb.Stretch = Stretch.Uniform;
            //vb.AlignmentY = AlignmentY.Top;
            //vb.ViewportUnits = BrushMappingMode.Absolute;
            //vb.Viewport = new Rect(16, 16, Container.ActualWidth, Container.ActualHeight);

            //PrintPreviewDialog pdlg = new PrintPreviewDialog(vb);
            //pdlg.Width = 779.685039370079;
            //pdlg.Height = Container.ActualHeight / Container.ActualWidth * pdlg.Width + 48;
            //pdlg.ShowDialog();

            var vb = new VisualBrush(Container);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(40, 30, Container.ActualWidth - 40, Container.ActualHeight - 30));
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
