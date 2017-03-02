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
    /// Interaction logic for WindowKetLuanGiamDinhTinhDuc.xaml
    /// </summary>
    public partial class WindowKetLuanGiamDinhTinhDuc : Window
    {
        string _MaHoSo, _MaKetLuanTinhDuc;
        object _DataContext;
        DataView dv;
        public WindowKetLuanGiamDinhTinhDuc()
        {
            InitializeComponent();
            btnEdit.Visibility = Visibility.Collapsed;
            btnDel.Visibility = Visibility.Collapsed;
        }
        public WindowKetLuanGiamDinhTinhDuc(string MaHoSo, object DataContext)
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
            TableKetLuanTinhDuc tblKLTD = new TableKetLuanTinhDuc();
            dv = tblKLTD.get_ketluantinhduc_by_hoso(_MaHoSo);
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                _MaKetLuanTinhDuc = dv[0]["MaKetLuanTinhDuc"].ToString();
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
            //string MaHoSo = _MaHoSo;
            //string NgayGioGiamDinh = dpNgayGiamDinh.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpKyNgay.SelectedDate.Value) + GioPhutGiamDinh : "";
            //string NguoiGiamDinh = txtNguoiGiamDinh.Text;
            //string VoiSuGiupDo = txtVoiSuGiupDo.Text;
            //string DieuTraVien = txtDieuTraVien.Text;
            //string DienThoaiDTV = txtDienThoaiDTV.Text;
            //string TinhHinhSuViec = txtTinhHinhSuViec.Text;
            //string NghienCuuHoSoTaiLieu = txtNghienCuuHoSoTaiLieu.Text;
            //string ThaiDo = txtThaiDo.Text;
            //string ChieuCao = txtChieuCao.Text;
            //string CanNang = txtCanNang.Text;
            //string Mach = txtMach.Text;
            //string HuyetAp = txtHuyetAp.Text;
            //string NhietDo = txtNhietDo.Text;
            //string NhipTho = txtNhipTho.Text;
            //string TinhDuc = txtThuongTich.Text;
            ////string CanLamSang = txtCanLamSang.Text;
            //string CanLamSang = "";
            //string DauHieuChinhQuaGiamDinh = txtDauHieuChinhQuaGiamDinh.Text;
            //string SucKhoeGiam = txtSucKhoeGiam.Text;
            //string TamThoi = txtTamThoi.Text;
            //string TamThoiBangChu = txtTamThoiBangChu.Text;
            //string VinhVien = txtVinhVien.Text;
            //string VinhVienBangChu = txtVinhVienBangChu.Text;

            //var KhongLayDuocMayPhetDichAmDao = chkKhongLayDuocMauPhetDichAmDao.IsChecked;
            //var LayDuocMayPhetDichAmDao = chkLayDuocMauPhetDichAmDao.IsChecked;

            string error = "",
                GioGiamDinh = txtHHMM.Hours != "" ? txtHHMM.Hours : "00",
                    PhutGiamDinh = txtHHMM.Minutes != "" ? txtHHMM.Minutes : "00",
                    GioPhutGiamDinh = GioGiamDinh + ":" + PhutGiamDinh;

            string MaHoSo = _MaHoSo;
            string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
            string NgayGioGiamDinh = dpNgayGiamDinh.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayGiamDinh.SelectedDate.Value) + GioPhutGiamDinh : "";
            string VoiSuGiupDo = txtVoiSuGiupDo.Text.TrimEnd();
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string TinhHinhSuViec = txtTinhHinhSuViec.Text.TrimEnd();
            string NghienCuuHoSoTaiLieu = txtNghienCuuHoSoTaiLieu.Text.TrimEnd();
            string LamSang = txtLamSang.Text.TrimEnd();
            string ThaiDo = txtThaiDo.Text.TrimEnd();
            string ChieuCao = txtChieuCao.Text.TrimEnd();
            string CanNang = txtCanNang.Text.TrimEnd();
            string HuyetAp = txtHuyetAp.Text.TrimEnd();
            string Mach = txtMach.Text.TrimEnd();
            string NhietDo = txtNhietDo.Text.TrimEnd();
            string QuanAo = txtQuanAo.Text.TrimEnd();
            string LongMu = txtLongMu.Text.TrimEnd();
            string MoiLon = txtMoiLon.Text.TrimEnd();
            string MoiBe = txtMoiBe.Text.TrimEnd();
            string AmHo = txtAmHo.Text.TrimEnd();
            string MangTrinh = txtMangTrinh.Text.TrimEnd();
            string AmDao = txtAmDao.Text.TrimEnd();
            string TangSinhMon = txtTangSinhMon.Text.TrimEnd();
            string HauMon = txtHauMon.Text.TrimEnd();
            string Dau = txtDau.Text.TrimEnd();
            string Co = txtCo.Text.TrimEnd();
            string Nguc = txtNguc.Text.TrimEnd();
            string Dui = txtDui.Text.TrimEnd();
            string Lung = txtLung.Text.TrimEnd();
            string Mong = txtMong.Text.TrimEnd();
            string TayChan = txtTayChan.Text.TrimEnd();
            string MaSo = txtMaSo.Text.TrimEnd();
            string LayMauPhetDichAmDao = lstLayMauPhetDichAmDao.SelectedValue != null ? lstLayMauPhetDichAmDao.SelectedValue.ToString() : "";
            string SoMauPhetDichAmDao = txtSoMauPhetDichAmDao.Text.TrimEnd();
            string Phodphatase = chkKhongThucHienPhodphatase.IsChecked.ToString() == "True" ? "" : txtPhodphatase.Text.TrimEnd();
            string Christmas = chkKhongThucHienChristmas.IsChecked.ToString() == "True" ? "" : txtChristmas.Text.TrimEnd();
            string LuuMauPhetDichAmDao = lstLuuMauPhetDichAmDao.SelectedValue != null ? lstLuuMauPhetDichAmDao.SelectedValue.ToString() : "";
            string LayMau = lstLayMau.SelectedValue != null ? lstLayMau.SelectedValue.ToString() : "";
            string QuetNiemMac = lstQuetNiemMac.SelectedValue != null ? lstQuetNiemMac.SelectedValue.ToString() : "";
            string SieuAmBung = lstSieuAmBung.SelectedValue != null ? lstSieuAmBung.SelectedValue.ToString() : "";
            string DauHieu = txtDauHieu.Text.TrimEnd();
            string KLKhac = txtKLKhac.Text.TrimEnd();
            string KhongThucHienPhodphatase = chkKhongThucHienPhodphatase.IsChecked.ToString();
            string KhongThucHienChristmas = chkKhongThucHienChristmas.IsChecked.ToString();
            string XetNghiemHIV = lstXetNghiemHIV.SelectedValue != null ? lstXetNghiemHIV.SelectedValue.ToString() : "";
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();
            string TheTrang = txtTheTrang.Text.TrimEnd();
            string KhamChuyenKhoa = txtKhamChuyenKhoa.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();

            if (string.IsNullOrEmpty(NgayGioGiamDinh))
                error += "- Nhập ngày giờ giám định!\n";
            if (string.IsNullOrEmpty(LayMauPhetDichAmDao))
                error += "- Chọn lấy mẫu phết dịch âm đạo!\n";
            if (string.IsNullOrEmpty(LuuMauPhetDichAmDao))
                error += "- Chọn lưu mẫu phết dịch âm đạo làm DNA!\n";
            if (string.IsNullOrEmpty(LayMau))
                error += "- Chọn lấy máu và lưu mẫu làm DNA!\n";
            if (string.IsNullOrEmpty(QuetNiemMac))
                error += "- Chọn quệt niêm mạc má và lưu mẫu làm DNA!\n";
            if (string.IsNullOrEmpty(SieuAmBung))
                error += "- Chọn siêu âm bụng tổng quát và sản - phụ khoa!\n";

            if (string.IsNullOrEmpty(error))
            {
                TableKetLuanTinhDuc tblKLTD = new TableKetLuanTinhDuc();
                tblKLTD.insert_ketluantinhduc(
                    MaHoSo,
                    NguoiGiamDinh,
                    NgayGioGiamDinh,
                    VoiSuGiupDo,
                    DieuTraVien,
                    DienThoaiDTV,
                    TinhHinhSuViec,
                    NghienCuuHoSoTaiLieu,
                    LamSang,
                    ThaiDo,
                    ChieuCao,
                    CanNang,
                    HuyetAp,
                    Mach,
                    NhietDo,
                    QuanAo,
                    LongMu,
                    MoiLon,
                    MoiBe,
                    AmHo,
                    MangTrinh,
                    AmDao,
                    TangSinhMon,
                    HauMon,
                    Dau,
                    Co,
                    Nguc,
                    Dui,
                    Lung,
                    Mong,
                    TayChan,
                    MaSo,
                    LayMauPhetDichAmDao,
                    SoMauPhetDichAmDao,
                    Phodphatase,
                    Christmas,
                    LuuMauPhetDichAmDao,
                    LayMau,
                    QuetNiemMac,
                    SieuAmBung,
                    DauHieu,
                    KLKhac,
                    KhongThucHienPhodphatase,
                    KhongThucHienChristmas,
                    XetNghiemHIV,
                    HoTen1,
                    DiaDiemGiamDinh,
                    HoSoTaiLieu,
                    NoiDungYeuCau,
                    NghienCuuHoSoBenhAn,
                    TheTrang,
                    KhamChuyenKhoa,
                    KetQuaCanLamSang
                    );

                MessageBox.Show("Thêm thành công.");
                LoadData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Thêm Kết luận giám định tình dục.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
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

            string MaKetLuanTinhDuc = _MaKetLuanTinhDuc;
            string MaHoSo = _MaHoSo;
            string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
            string NgayGioGiamDinh = dpNgayGiamDinh.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayGiamDinh.SelectedDate.Value) + GioPhutGiamDinh : "";
            string VoiSuGiupDo = txtVoiSuGiupDo.Text.TrimEnd();
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string TinhHinhSuViec = txtTinhHinhSuViec.Text.TrimEnd();
            string NghienCuuHoSoTaiLieu = txtNghienCuuHoSoTaiLieu.Text.TrimEnd();
            string LamSang = txtLamSang.Text.TrimEnd();
            string ThaiDo = txtThaiDo.Text.TrimEnd();
            string ChieuCao = txtChieuCao.Text.TrimEnd();
            string CanNang = txtCanNang.Text.TrimEnd();
            string HuyetAp = txtHuyetAp.Text.TrimEnd();
            string Mach = txtMach.Text.TrimEnd();
            string NhietDo = txtNhietDo.Text.TrimEnd();
            string QuanAo = txtQuanAo.Text.TrimEnd();
            string LongMu = txtLongMu.Text.TrimEnd();
            string MoiLon = txtMoiLon.Text.TrimEnd();
            string MoiBe = txtMoiBe.Text.TrimEnd();
            string AmHo = txtAmHo.Text.TrimEnd();
            string MangTrinh = txtMangTrinh.Text.TrimEnd();
            string AmDao = txtAmDao.Text.TrimEnd();
            string TangSinhMon = txtTangSinhMon.Text.TrimEnd();
            string HauMon = txtHauMon.Text.TrimEnd();
            string Dau = txtDau.Text.TrimEnd();
            string Co = txtCo.Text.TrimEnd();
            string Nguc = txtNguc.Text.TrimEnd();
            string Dui = txtDui.Text.TrimEnd();
            string Lung = txtLung.Text.TrimEnd();
            string Mong = txtMong.Text.TrimEnd();
            string TayChan = txtTayChan.Text.TrimEnd();
            string MaSo = txtMaSo.Text.TrimEnd();
            string LayMauPhetDichAmDao = lstLayMauPhetDichAmDao.SelectedValue != null ? lstLayMauPhetDichAmDao.SelectedValue.ToString() : "";
            string SoMauPhetDichAmDao = txtSoMauPhetDichAmDao.Text.TrimEnd();
            string Phodphatase = chkKhongThucHienPhodphatase.IsChecked.ToString() == "True" ? "" : txtPhodphatase.Text.TrimEnd();
            string Christmas = chkKhongThucHienChristmas.IsChecked.ToString() == "True" ? "" : txtChristmas.Text.TrimEnd();
            string LuuMauPhetDichAmDao = lstLuuMauPhetDichAmDao.SelectedValue != null ? lstLuuMauPhetDichAmDao.SelectedValue.ToString() : "";
            string LayMau = lstLayMau.SelectedValue != null ? lstLayMau.SelectedValue.ToString() : "";
            string QuetNiemMac = lstQuetNiemMac.SelectedValue != null ? lstQuetNiemMac.SelectedValue.ToString() : "";
            string SieuAmBung = lstSieuAmBung.SelectedValue != null ? lstSieuAmBung.SelectedValue.ToString() : "";
            string DauHieu = txtDauHieu.Text.TrimEnd();
            string KLKhac = txtKLKhac.Text.TrimEnd();
            string KhongThucHienPhodphatase = chkKhongThucHienPhodphatase.IsChecked.ToString();
            string KhongThucHienChristmas = chkKhongThucHienChristmas.IsChecked.ToString();
            string XetNghiemHIV = lstXetNghiemHIV.SelectedValue != null ? lstXetNghiemHIV.SelectedValue.ToString() : "";
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();
            string TheTrang = txtTheTrang.Text.TrimEnd();
            string KhamChuyenKhoa = txtKhamChuyenKhoa.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();

            if (string.IsNullOrEmpty(NgayGioGiamDinh))
                error += "- Nhập ngày giờ giám định!\n";
            if (string.IsNullOrEmpty(LayMauPhetDichAmDao))
                error += "- Chọn lấy mẫu phết dịch âm đạo!\n";
            if (string.IsNullOrEmpty(LuuMauPhetDichAmDao))
                error += "- Chọn lưu mẫu phết dịch âm đạo làm DNA!\n";
            if (string.IsNullOrEmpty(LayMau))
                error += "- Chọn lấy máu và lưu mẫu làm DNA!\n";
            if (string.IsNullOrEmpty(QuetNiemMac))
                error += "- Chọn quệt niêm mạc má và lưu mẫu làm DNA!\n";
            if (string.IsNullOrEmpty(SieuAmBung))
                error += "- Chọn siêu âm bụng tổng quát và sản - phụ khoa!\n";

            if (string.IsNullOrEmpty(error))
            {
                TableKetLuanTinhDuc tblKLTD = new TableKetLuanTinhDuc();
                tblKLTD.update_ketluantinhduc(
                        MaKetLuanTinhDuc,
                        MaHoSo,
                        NguoiGiamDinh,
                        NgayGioGiamDinh,
                        VoiSuGiupDo,
                        DieuTraVien,
                        DienThoaiDTV,
                        TinhHinhSuViec,
                        NghienCuuHoSoTaiLieu,
                        LamSang,
                        ThaiDo,
                        ChieuCao,
                        CanNang,
                        HuyetAp,
                        Mach,
                        NhietDo,
                        QuanAo,
                        LongMu,
                        MoiLon,
                        MoiBe,
                        AmHo,
                        MangTrinh,
                        AmDao,
                        TangSinhMon,
                        HauMon,
                        Dau,
                        Co,
                        Nguc,
                        Dui,
                        Lung,
                        Mong,
                        TayChan,
                        MaSo,
                        LayMauPhetDichAmDao,
                        SoMauPhetDichAmDao,
                        Phodphatase,
                        Christmas,
                        LuuMauPhetDichAmDao,
                        LayMau,
                        QuetNiemMac,
                        SieuAmBung,
                        DauHieu,
                        KLKhac,
                        KhongThucHienPhodphatase,
                        KhongThucHienChristmas,
                        XetNghiemHIV,
                        HoTen1,
                        DiaDiemGiamDinh,
                        HoSoTaiLieu,
                        NoiDungYeuCau,
                        NghienCuuHoSoBenhAn,
                        TheTrang,
                        KhamChuyenKhoa,
                        KetQuaCanLamSang

                    );
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Sửa Kết luận giám định tình dục.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
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
                App.ThemHanhDong(MainWindow._MaNhanVien, "Xoá Kết luận giám định tình dục.", _MaHoSo, ((DataRowView)_DataContext)["SoHoSo"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), ((DataRowView)_DataContext)["QDTCGDSo"].ToString());
                TableKetLuanTinhDuc tblKLTD = new TableKetLuanTinhDuc();
                tblKLTD.delete_ketluantinhduc(_MaKetLuanTinhDuc);
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
                    prefix = "";
                }
                else
                {
                    prefix = prefix.Trim() + Environment.NewLine;
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
                    prefix = "";
                }
                else
                {
                    prefix = prefix.Trim() + Environment.NewLine;
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
        }
    }
}
