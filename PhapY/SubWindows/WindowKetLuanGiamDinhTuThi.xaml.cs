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
    /// Interaction logic for WindowKetLuanGiamDinhTuThi.xaml
    /// </summary>
    public partial class WindowKetLuanGiamDinhTuThi : Window
    {
        string _MaHoSo, _MaKetLuanTuThi;
        object _DataContext;
        DataView dv;
        public WindowKetLuanGiamDinhTuThi()
        {
            InitializeComponent();
            btnEdit.Visibility = Visibility.Collapsed;
            btnDel.Visibility = Visibility.Collapsed;
        }
        public WindowKetLuanGiamDinhTuThi(string MaHoSo, object DataContext)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            _DataContext = DataContext;
            LoadData();
        }
        private void LoadData()
        {
            Container.DataContext = _DataContext;
            TableKetLuanTuThi tblKLTT = new TableKetLuanTuThi();
            dv = tblKLTT.get_ketluantuthi_by_hoso(_MaHoSo);
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                _MaKetLuanTuThi = dv[0]["MaKetLuanTuThi"].ToString();
                btnAdd.Visibility = Visibility.Collapsed;
                btnEdit.Visibility = Visibility.Visible;
                btnDel.Visibility = Visibility.Visible;
            }
            else
            {
                btnAdd.Visibility = Visibility.Visible;
                btnEdit.Visibility = Visibility.Collapsed;
                btnDel.Visibility = Visibility.Collapsed;
            }
        }
        private void print()
        {
            var vb = new VisualBrush(scroll1);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(16, 16, scroll1.ActualWidth, scroll1.ActualHeight));
            dc.Close();

            var printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(vis, "Print");
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            print();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string error = "",
                GioBatDau = txtGioPhutBatDau.Hours != "" ? txtGioPhutBatDau.Hours : "00",
                PhutBatDau = txtGioPhutBatDau.Minutes != "" ? txtGioPhutBatDau.Minutes : "00",
                GioPhutBatDau = GioBatDau + ":" + PhutBatDau,
                GioKetThuc = txtGioPhutKetThuc.Hours != "" ? txtGioPhutKetThuc.Hours : "00",
                PhutKetThuc = txtGioPhutKetThuc.Minutes != "" ? txtGioPhutKetThuc.Minutes : "00",
                GioPhutKetThuc = GioKetThuc + ":" + PhutKetThuc;

            string MaHoSo = _MaHoSo;
		    string NguoiGiamDinh = txtNguoiGiamDinh.Text;
		    string NgayBatDau = dpNgayBatDau.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayBatDau.SelectedDate.Value) + GioPhutBatDau : "";
		    string NgayKetThuc = dpNgayKetThuc.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayKetThuc.SelectedDate.Value) + GioPhutKetThuc : "";
		    string DieuTraVien = txtDieuTraVien.Text;
		    string DienThoaiDTV = txtDienThoaiDTV.Text;
		    string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text;
		    string DieuKienAnhSangThoiTiet = txtDiaDiemGiamDinh.Text;
            string NguoiChungKien = txtNguoiChungKien.Text;
            string NoiDungSuViec = txtNoiDungSuViec.Text;
            string TienSuCaNhan = txtTienSuCaNhan.Text;
            string NhanDangVaTinhTrangTuThi = txtNhanDangVaTinhTrangTuThi.Text;
            string CacDauVetThuongTich = txtCacDauVetThuongTich.Text;
            string KhamTrong = txtKhamTrong.Text;
            string SoViThe1 = txtSoViThe1.Text;
            string SoViThe2 = txtSoViThe2.Text;
            string XetNghiemTeBao_MoBenhHoc = txtXetNghiemTeBao_MoBenhHoc.Text;
            string CacXetNghiemKhac = txtCacXetNghiemKhac.Text;
            string NguyenNhanChet = txtNguyenNhanChet.Text;
            string PhuMo1 = txtPhuMo1.Text;
            string PhuMo2 = txtPhuMo2.Text;
            string GiamDinhVien1 = txtGiamDinhVien1.Text;
            string GiamDinhVien2 = txtGiamDinhVien2.Text;

            if (string.IsNullOrEmpty(NgayBatDau))
                error += "- Nhập ngày giờ bắt đầu giám định!\n";
            if (string.IsNullOrEmpty(NgayKetThuc))
                error += "- Nhập ngày giờ kết thúc giám định!\n";

            if (string.IsNullOrEmpty(error))
            {

                TableKetLuanTuThi tblKLTT = new TableKetLuanTuThi();
                tblKLTT.insert_ketluantuthi(
                    MaHoSo,
                    NguoiGiamDinh,
                    NgayBatDau,
                    NgayKetThuc,
                    DieuTraVien,
                    DienThoaiDTV,
                    DiaDiemGiamDinh,
                    DieuKienAnhSangThoiTiet,
                    NguoiChungKien,
                    NoiDungSuViec,
                    TienSuCaNhan,
                    NhanDangVaTinhTrangTuThi,
                    CacDauVetThuongTich,
                    KhamTrong,
                    SoViThe1,
                    SoViThe2,
                    XetNghiemTeBao_MoBenhHoc,
                    CacXetNghiemKhac,
                    NguyenNhanChet,
                    PhuMo1,
                    PhuMo2,
                    GiamDinhVien1,
                    GiamDinhVien2
                    );
                MessageBox.Show("Thêm thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show(error);
            }

        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.GetBuffer();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.gif,*.png,*.bmp)|*.jpg; *.gif;*.png;*.bmp";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageSource imgS = new BitmapImage(new Uri(ofd.FileName));
                imgHinhDuongSu.Source = imgS;
                //change the status when image is changed
                tblCheckImageStatus.Text = "1";
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            string error = "",
                GioBatDau = txtGioPhutBatDau.Hours != "" ? txtGioPhutBatDau.Hours : "00",
                PhutBatDau = txtGioPhutBatDau.Minutes != "" ? txtGioPhutBatDau.Minutes : "00",
                GioPhutBatDau = GioBatDau + ":" + PhutBatDau,
                GioKetThuc = txtGioPhutKetThuc.Hours != "" ? txtGioPhutKetThuc.Hours : "00",
                PhutKetThuc = txtGioPhutKetThuc.Minutes != "" ? txtGioPhutKetThuc.Minutes : "00",
                GioPhutKetThuc = GioKetThuc + ":" + PhutKetThuc;

            string MaHoSo = _MaHoSo;
            string NguoiGiamDinh = txtNguoiGiamDinh.Text;
            string NgayBatDau = dpNgayBatDau.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayBatDau.SelectedDate.Value) + GioPhutBatDau : "";
            string NgayKetThuc = dpNgayKetThuc.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayKetThuc.SelectedDate.Value) + GioPhutKetThuc : "";
            string DieuTraVien = txtDieuTraVien.Text;
            string DienThoaiDTV = txtDienThoaiDTV.Text;
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text;
            string DieuKienAnhSangThoiTiet = txtDiaDiemGiamDinh.Text;
            string NguoiChungKien = txtNguoiChungKien.Text;
            string NoiDungSuViec = txtNoiDungSuViec.Text;
            string TienSuCaNhan = txtTienSuCaNhan.Text;
            string NhanDangVaTinhTrangTuThi = txtNhanDangVaTinhTrangTuThi.Text;
            string CacDauVetThuongTich = txtCacDauVetThuongTich.Text;
            string KhamTrong = txtKhamTrong.Text;
            string SoViThe1 = txtSoViThe1.Text;
            string SoViThe2 = txtSoViThe2.Text;
            string XetNghiemTeBao_MoBenhHoc = txtXetNghiemTeBao_MoBenhHoc.Text;
            string CacXetNghiemKhac = txtCacXetNghiemKhac.Text;
            string NguyenNhanChet = txtNguyenNhanChet.Text;
            string PhuMo1 = txtPhuMo1.Text;
            string PhuMo2 = txtPhuMo2.Text;
            string GiamDinhVien1 = txtGiamDinhVien1.Text;
            string GiamDinhVien2 = txtGiamDinhVien2.Text;

            if (string.IsNullOrEmpty(NgayBatDau))
                error += "- Nhập ngày giờ bắt đầu giám định!\n";
            if (string.IsNullOrEmpty(NgayKetThuc))
                error += "- Nhập ngày giờ kết thúc giám định!\n";

            if (string.IsNullOrEmpty(error))
            {

                TableKetLuanTuThi tblKLTT = new TableKetLuanTuThi();
                tblKLTT.update_ketluantuthi(
                    _MaKetLuanTuThi,
                    MaHoSo,
                    NguoiGiamDinh,
                    NgayBatDau,
                    NgayKetThuc,
                    DieuTraVien,
                    DienThoaiDTV,
                    DiaDiemGiamDinh,
                    DieuKienAnhSangThoiTiet,
                    NguoiChungKien,
                    NoiDungSuViec,
                    TienSuCaNhan,
                    NhanDangVaTinhTrangTuThi,
                    CacDauVetThuongTich,
                    KhamTrong,
                    SoViThe1,
                    SoViThe2,
                    XetNghiemTeBao_MoBenhHoc,
                    CacXetNghiemKhac,
                    NguyenNhanChet,
                    PhuMo1,
                    PhuMo2,
                    GiamDinhVien1,
                    GiamDinhVien2
                    );
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xoá dòng này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
            {
                TableKetLuanTuThi tblKLTT = new TableKetLuanTuThi();
                tblKLTT.delete_ketluantuthi(_MaKetLuanTuThi);
                DataTable dt = dv.ToTable();
                dt.Clear();
                var dr = dt.NewRow();
                dt.Rows.Add(dr);
                Container.DataContext = dt.DefaultView[0];
                LoadData();
            }
        }
    }
}
