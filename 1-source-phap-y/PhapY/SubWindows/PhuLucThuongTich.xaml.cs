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
    /// Interaction logic for PhuLucThuongTich.xaml
    /// </summary>
    public partial class PhuLucThuongTich : Window
    {
        string _MaHoSo;
        public PhuLucThuongTich(string MaHoSo,string SoHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            tblSoHoSo.Text = SoHoSo;
            var tblPLTT = new TablePhuLucThuongTich();
            Container.DataContext = tblPLTT.get_phulucthuongtich(MaHoSo);
            lblCurrentDate.Content = string.Format("{0:dd}", DateTime.Now);
            lblCurrentMonth.Content = string.Format("{0:MM}", DateTime.Now);
            lblCurrentYear.Content = string.Format("{0:yyyy}", DateTime.Now);
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role2)
            {
                btnUpdate.Visibility = Visibility.Collapsed;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string MaHoSo = _MaHoSo;
	        string BanGiamDinhYPhap = chkBanGiamDinhYPhap.IsChecked.Value.ToString();
            string BanKetLuanThuongTich = chkBanKetLuanThuongTich.IsChecked.Value.ToString();
            string QuyetDinhTrungCauGiamDinh = chkQuyetDinhTrungCauGiamDinh.IsChecked.Value.ToString();
            string BanSaoCMNDHoChieu = chkBanSaoCMNDHoChieu.IsChecked.Value.ToString();
            string GiayRavien = chkGiayRavien.IsChecked.Value.ToString();
            string GiayChungNhanThuongTich = chkGiayChungNhanThuongTich.IsChecked.Value.ToString();
            string BienBanXemXetDauVetCoThe = chkBienBanXemXetDauVetCoThe.IsChecked.Value.ToString();
            string ToaThuoc = chkToaThuoc.IsChecked.Value.ToString();
            string YChung = chkYChung.IsChecked.Value.ToString();
            string XQ = chkXQ.IsChecked.Value.ToString();
            string XQA = txtXQA.Text;
            string XQB = txtXQB.Text;
            string EEG = chkEEG.IsChecked.Value.ToString();
            string EMG = chkEMG.IsChecked.Value.ToString();
            string ECG = chkECG.IsChecked.Value.ToString();
            string MRI = chkMRI.IsChecked.Value.ToString();
            string SieuAm = chkSieuAm.IsChecked.Value.ToString();
            string CTScanner = chkCTScanner.IsChecked.Value.ToString();
            string CTScannerInput = txtCTScanner.Text.Trim();
            string XetNghiem = chkXetNghiem.IsChecked.Value.ToString();
            string NoiSoi = chkNoiSoi.IsChecked.Value.ToString();
            string TMH = chkTMH.IsChecked.Value.ToString();
            string RHM = chkRHM.IsChecked.Value.ToString();
            string CTCH = chkCTCH.IsChecked.Value.ToString();
            string Mat = chkMat.IsChecked.Value.ToString();
            string NoiTimMach = chkNoiTimMach.IsChecked.Value.ToString();
            string NoiTieuHoa = chkNoiTieuHoa.IsChecked.Value.ToString();
            string NoiTiet = chkNoiTiet.IsChecked.Value.ToString();
            string NoiThanKinh = chkNoiThanKinh.IsChecked.Value.ToString();
            string NoiHoHap = chkNoiHoHap.IsChecked.Value.ToString();
            string Lao = chkLao.IsChecked.Value.ToString();
            string SoDoPhacHoa = chkSoDoPhacHoa.IsChecked.Value.ToString();
            string Chup = txtChup.Text;
            string SoKhamBenh = chkSoKhamBenh.IsChecked.Value.ToString();
            string BenhAnTomTat = chkBenhAnTomTat.IsChecked.Value.ToString();
            string BanSaoHoSoBenhAn = chkBanSaoHoSoBenhAn.IsChecked.Value.ToString();
            string BienBanGiaoNhanTaiLieuGiamDinh = chkBienBanGiaoNhanTaiLieuGiamDinh.IsChecked.Value.ToString();
            string GiayCamKetKhongKhamChuyenKhoa = chkGiayCamKetKhongKhamChuyenKhoa.IsChecked.Value.ToString();
            string GiayCamKetInput = txtGiayCamKetInput.Text.Trim();
            string CongVanSo = chkCongVanSo.IsChecked.Value.ToString();
            string NoiDungCongVan = txtNoiDungCongVan.Text;
            string Khac = chkKhac.IsChecked.Value.ToString();
            string NoiDungKhac = txtNoiDungKhac.Text;
            string TongCong = txtTongCong.Text;
            string BenhAnCapCuu = chkBenhAnCapCuu.IsChecked.Value.ToString();
            string BenhAnNgoaiChuan = chkBenhAnNgoaiChuan.IsChecked.Value.ToString();
            string MRIInput = txtMRIInput.Text.Trim();
            string CNHH = chkCNHH.IsChecked.Value.ToString();
            var tblPLTT = new TablePhuLucThuongTich();
            tblPLTT.update_phulucthuongtich(
                    MaHoSo,
 	                BanGiamDinhYPhap,
 	                BanKetLuanThuongTich,
 	                QuyetDinhTrungCauGiamDinh,
 	                BanSaoCMNDHoChieu,
 	                GiayRavien,
 	                GiayChungNhanThuongTich,
 	                BienBanXemXetDauVetCoThe,
 	                ToaThuoc,
 	                YChung,
 	                XQ,
 	                XQA,
 	                XQB,
 	                EEG,
 	                EMG,
 	                ECG,
 	                MRI,
 	                SieuAm,
 	                CTScanner,
                    CTScannerInput,
 	                XetNghiem,
 	                NoiSoi,
 	                TMH,
 	                RHM,
 	                CTCH,
 	                Mat,
 	                NoiTimMach,
 	                NoiTieuHoa,
 	                NoiTiet,
 	                NoiThanKinh,
 	                NoiHoHap,
 	                Lao,
 	                SoDoPhacHoa,
 	                Chup,
 	                SoKhamBenh,
 	                BenhAnTomTat,
 	                BanSaoHoSoBenhAn,
 	                BienBanGiaoNhanTaiLieuGiamDinh,
 	                GiayCamKetKhongKhamChuyenKhoa,
                    GiayCamKetInput,
 	                CongVanSo,
 	                NoiDungCongVan,
 	                Khac,
 	                NoiDungKhac,
 	                TongCong,
                    BenhAnCapCuu,
                    BenhAnNgoaiChuan,
                    MRIInput,
                    CNHH
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
            //pdlg.Height = 700;
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
