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
    /// Interaction logic for WindowKetLuanGiamDinhThuongTich.xaml
    /// </summary>
    public partial class WindowKetLuanGiamDinhThuongTich : Window
    {
        string _MaHoSo, _MaKetLuanThuongTich;
        object _DataContext;
        static int i = 1;
        static int z = 1;
        DataView dv;
        public WindowKetLuanGiamDinhThuongTich()
        {
            InitializeComponent();
            btnEdit.Visibility = Visibility.Collapsed;
            btnDel.Visibility = Visibility.Collapsed;
        }
        public WindowKetLuanGiamDinhThuongTich(string MaHoSo, object DataContext)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            _DataContext = DataContext;
            LoadData();
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role2)
            {
                btnAdd.Visibility = btnChonBS.Visibility = btnDel.Visibility = btnEdit.Visibility = Visibility.Collapsed;
            }
        }
        private void LoadData()
        {
            Container.DataContext = _DataContext;
            TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
            dv = tblKLTT.get_ketluanthuongtich_by_hoso(_MaHoSo);
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                _MaKetLuanThuongTich = dv[0]["MaKetLuanThuongTich"].ToString();
                btnAdd.Visibility = Visibility.Collapsed;
                btnEdit.Visibility = Visibility.Visible;
                btnDel.Visibility = Visibility.Visible;

                lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
                lblThang.Content = string.Format("{0:MM}", DateTime.Now);
                lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);

                if (bool.Parse(dv[0]["TinhTrangHoSo"].ToString()))
                {
                    btnEdit.Visibility = Visibility.Collapsed;
                    btnDel.Visibility = Visibility.Collapsed;
                }
                else
                {
                    btnEdit.Visibility = Visibility.Visible;
                    btnDel.Visibility = Visibility.Visible;
                }
            }
            else
            {
                //DataTable dt = new DataTable();
                //dt.Columns.Add("DiaDiemGiamDinh");
                //DataRow dr = dt.NewRow();
                //dr["DiaDiemGiamDinh"] = "TRUNG TÂM PHÁP Y";
                //dt.Rows.Add(dr);
                //_DataContext = dt.DefaultView[0];
                //Container.DataContext = dt

                btnAdd.Visibility = Visibility.Visible;
                btnEdit.Visibility = Visibility.Collapsed;
                btnDel.Visibility = Visibility.Collapsed;

                lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
                lblThang.Content = string.Format("{0:MM}", DateTime.Now);
                lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);
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
                GioGiamDinh = txtHHMM.Hours != "" ? txtHHMM.Hours : "00",
                    PhutGiamDinh = txtHHMM.Minutes != "" ? txtHHMM.Minutes : "00",
                    GioPhutGiamDinh = GioGiamDinh + ":" + PhutGiamDinh;

            string MaHoSo = _MaHoSo;
            string NgayGioGiamDinh = dpNgayGiamDinh.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayGiamDinh.SelectedDate.Value) + GioPhutGiamDinh : "";
            string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
            string VoiSuGiupDo = txtVoiSuGiupDo.Text.TrimEnd();
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string TinhHinhSuViec = txtTinhHinhSuViec.Text.TrimEnd();
            string NghienCuuHoSoTaiLieu = txtNghienCuuHoSoTaiLieu.Text.TrimEnd();
            string ThaiDo = txtThaiDo.Text.TrimEnd();
            string ChieuCao = txtChieuCao.Text.TrimEnd();
            string CanNang = txtCanNang.Text.TrimEnd();
            string Mach = txtMach.Text.TrimEnd();
            string HuyetAp = txtHuyetAp.Text.TrimEnd();
            string NhietDo = txtNhietDo.Text.TrimEnd();
            string NhipTho = txtNhipTho.Text.TrimEnd();
            string ThuongTich = txtThuongTich.Text.TrimEnd();
            string CanLamSang = txtCanLamSang.Text.TrimEnd();
            string DauHieuChinhQuaGiamDinh = txtDauHieuChinhQuaGiamDinh.Text.TrimEnd();
            string SucKhoeGiam = txtSucKhoeGiam.Text.TrimEnd();
            string TamThoi = txtTamThoi.Text.TrimEnd();
            string TamThoiBangChu = txtTamThoiBangChu.Text.TrimEnd();
            string VinhVien = txtVinhVien.Text.TrimEnd();
            string VinhVienBangChu = txtVinhVienBangChu.Text.TrimEnd();
            string TomTatTinhHinhSuViec = txtTomTatTinhHinhSuViec.Text.TrimEnd();
            string SucKhoeGiamBangChu = txtSucKhoeGiamBangChu.Text.TrimEnd();
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();
            string TheTrang = txtTheTrang.Text.TrimEnd();
            string LamSang = txtLamSang.Text.TrimEnd();
            string KhamChuyenKhoa = txtKhamChuyenKhoa.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();
            string KetLuanKhac = txtKetLuanKhac.Text.TrimEnd();

            if (string.IsNullOrEmpty(NgayGioGiamDinh))
                error += "- Nhập ngày giờ giám định!\n";

            if (string.IsNullOrEmpty(error))
            {

                TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
                tblKLTT.insert_ketluanthuongtich(
                    MaHoSo,
                    NgayGioGiamDinh,
                    NguoiGiamDinh,
                    VoiSuGiupDo,
                    DieuTraVien,
                    DienThoaiDTV,
                    TinhHinhSuViec,
                    NghienCuuHoSoTaiLieu,
                    ThaiDo,
                    ChieuCao,
                    CanNang,
                    Mach,
                    HuyetAp,
                    NhietDo,
                    NhipTho,
                    ThuongTich,
                    CanLamSang,
                    DauHieuChinhQuaGiamDinh,
                    SucKhoeGiam,
                    TamThoi,
                    TamThoiBangChu,
                    VinhVien,
                    VinhVienBangChu,
                    TomTatTinhHinhSuViec,
                    SucKhoeGiamBangChu,
                    HoTen1,
                    DiaDiemGiamDinh,
                    HoSoTaiLieu,
                    NoiDungYeuCau,
                    NghienCuuHoSoBenhAn,
                    TheTrang,
                    LamSang,
                    KhamChuyenKhoa,
                    KetQuaCanLamSang,
                    KetLuanKhac
                    );
                MessageBox.Show("Thêm thành công.");
                LoadData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Thêm Kết luận giám định thương tích.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
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
                GioGiamDinh = txtHHMM.Hours != "" ? txtHHMM.Hours : "00",
                    PhutGiamDinh = txtHHMM.Minutes != "" ? txtHHMM.Minutes : "00",
                    GioPhutGiamDinh = GioGiamDinh + ":" + PhutGiamDinh;

            string MaHoSo = _MaHoSo;
            string NgayGioGiamDinh = dpNgayGiamDinh.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayGiamDinh.SelectedDate.Value) + GioPhutGiamDinh : "";
            string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
            string VoiSuGiupDo = txtVoiSuGiupDo.Text.TrimEnd();
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string TinhHinhSuViec = txtTinhHinhSuViec.Text.TrimEnd();
            string NghienCuuHoSoTaiLieu = txtNghienCuuHoSoTaiLieu.Text.TrimEnd();
            string ThaiDo = txtThaiDo.Text.TrimEnd();
            string ChieuCao = txtChieuCao.Text.TrimEnd();
            string CanNang = txtCanNang.Text.TrimEnd();
            string Mach = txtMach.Text.TrimEnd();
            string HuyetAp = txtHuyetAp.Text.TrimEnd();
            string NhietDo = txtNhietDo.Text.TrimEnd();
            string NhipTho = txtNhipTho.Text.TrimEnd();
            string ThuongTich = txtThuongTich.Text.TrimEnd();
            string CanLamSang = txtCanLamSang.Text.TrimEnd();
            string DauHieuChinhQuaGiamDinh = txtDauHieuChinhQuaGiamDinh.Text.TrimEnd();
            string SucKhoeGiam = txtSucKhoeGiam.Text.TrimEnd();
            string TamThoi = txtTamThoi.Text.TrimEnd();
            string TamThoiBangChu = txtTamThoiBangChu.Text.TrimEnd();
            string VinhVien = txtVinhVien.Text.TrimEnd();
            string VinhVienBangChu = txtVinhVienBangChu.Text.TrimEnd();
            string TomTatTinhHinhSuViec = txtTomTatTinhHinhSuViec.Text.TrimEnd();
            string SucKhoeGiamBangChu = txtSucKhoeGiamBangChu.Text.TrimEnd();
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();
            string TheTrang = txtTheTrang.Text.TrimEnd();
            string LamSang = txtLamSang.Text.TrimEnd();
            string KhamChuyenKhoa = txtKhamChuyenKhoa.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();
            string KetLuanKhac = txtKetLuanKhac.Text.TrimEnd();

            if (string.IsNullOrEmpty(NgayGioGiamDinh))
                error += "- Nhập ngày giờ giám định!\n";

            if (string.IsNullOrEmpty(error))
            {
                TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
                tblKLTT.update_ketluanthuongtich(
                    _MaKetLuanThuongTich,
                    MaHoSo,
                    NgayGioGiamDinh,
                    NguoiGiamDinh,
                    VoiSuGiupDo,
                    DieuTraVien,
                    DienThoaiDTV,
                    TinhHinhSuViec,
                    NghienCuuHoSoTaiLieu,
                    ThaiDo,
                    ChieuCao,
                    CanNang,
                    Mach,
                    HuyetAp,
                    NhietDo,
                    NhipTho,
                    ThuongTich,
                    CanLamSang,
                    DauHieuChinhQuaGiamDinh,
                    SucKhoeGiam,
                    TamThoi,
                    TamThoiBangChu,
                    VinhVien,
                    VinhVienBangChu,
                    TomTatTinhHinhSuViec,
                    SucKhoeGiamBangChu,
                    HoTen1,
                    DiaDiemGiamDinh,
                    HoSoTaiLieu,
                    NoiDungYeuCau,
                    NghienCuuHoSoBenhAn,
                    TheTrang,
                    LamSang,
                    KhamChuyenKhoa,
                    KetQuaCanLamSang,
                    KetLuanKhac
                    );
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Sửa Kết luận giám định thương tích.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
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
                App.ThemHanhDong(MainWindow._MaNhanVien, "Xoá Kết luận giám định thương tích.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
                TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
                tblKLTT.delete_ketluanthuongtich(_MaKetLuanThuongTich);
                DataTable dt = dv.ToTable();
                dt.Clear();
                var dr = dt.NewRow();
                dt.Rows.Add(dr);
                Container.DataContext = dt.DefaultView[0];
                LoadData();
            }
        }

        private void btnChonBS_Click(object sender, RoutedEventArgs e)
        {
            var wdChonBS = new WindowChonBacSi();
            wdChonBS.ShowDialog();
            if (!string.IsNullOrEmpty(wdChonBS.TenNhanVien))
            {
                string prefix = txtNguoiGiamDinh.Text;
                if (string.IsNullOrEmpty(prefix.Trim()))
                {
                    //prefix = "";
                    prefix = "" + i + ". ";
                }
                else
                {
                    //prefix = prefix.Trim() + Environment.NewLine;
                    prefix = prefix.Trim() + Environment.NewLine + i + ". ";
                }

                if (!string.IsNullOrEmpty(wdChonBS.SoThe))
                {
                    txtNguoiGiamDinh.Text = prefix + (wdChonBS.TenNhanVien + "\t\tChức vụ: Giám Định Viên\n\t\t\t\tSố thẻ: " + wdChonBS.SoThe + "/TP-GĐTP").Trim();
                }
                else
                {
                    txtNguoiGiamDinh.Text = prefix + (wdChonBS.TenNhanVien + "\t\tChức vụ: " + wdChonBS.ChucVu).Trim();
                }
            }
            i++;
        }

        private void btnChonBS1_Click(object sender, RoutedEventArgs e)
        {
            var wdChonBS = new WindowChonBacSi();
            wdChonBS.ShowDialog();
            if (!string.IsNullOrEmpty(wdChonBS.TenNhanVien))
            {
                string prefix = txtVoiSuGiupDo.Text;
                if (string.IsNullOrEmpty(prefix.Trim()))
                {
                    prefix = "" + z + ". ";
                }
                else
                {
                    prefix = prefix.Trim() + Environment.NewLine + z + ". ";
                }

                if (!string.IsNullOrEmpty(wdChonBS.SoThe))
                {
                    txtVoiSuGiupDo.Text = prefix + (wdChonBS.TenNhanVien + "\t\tChức vụ: Giám Định Viên\n\t\t\t\tSố thẻ: " + wdChonBS.SoThe + "/TP-GĐTP").Trim();
                }
                else
                {
                    txtVoiSuGiupDo.Text = prefix + (wdChonBS.TenNhanVien + "\t\tChức vụ: " + wdChonBS.ChucVu).Trim();
                }
            }
            z++;
        }
    }
}
