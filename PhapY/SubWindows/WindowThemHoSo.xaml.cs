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
    /// Interaction logic for WindowThemHoSo.xaml
    /// </summary>
    public partial class WindowThemHoSo : Window
    {
        DanhSachHoSo dshs;
        public WindowThemHoSo(DanhSachHoSo dshs)
        {
            InitializeComponent();
            this.dshs = dshs;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDel.Visibility = Visibility.Collapsed;
            var tbl = new TableHoSo();
            cbbLoaiHS.ItemsSource = tbl.get_LoaiHoSoTTKT();
        }
        public WindowThemHoSo(DanhSachHoSo dshs, object DataContext)
        {
            InitializeComponent();
            this.dshs = dshs;
            btnAdd.Visibility = Visibility.Collapsed;
            Container.DataContext = DataContext;
            var tbl = new TableHoSo();
            cbbLoaiHS.ItemsSource = tbl.get_LoaiHoSoTTKT();
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string SoHoSo = txtSoHoSo.Text;
            string QDTCGDSo = txtQDTCGDSo.Text;
            string CoQuanTrungCau = txtCoQuanTrungCau.Text;
            string KyNgay = dpKyNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpKyNgay.SelectedDate.Value) : "";
            string HoTen = txtHoTen.Text;
            byte[] HinhDuongSu = imgHinhDuongSu.Source != null ? getJPGFromImageControl(((BitmapImage)imgHinhDuongSu.Source), 150) : new byte[0];
            string QuocTich = txtQuocTich.Text;
            string NgayDenLamHoSo = dpNgayDenLamHoSo.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpNgayDenLamHoSo.SelectedDate.Value) : "";
            string TaiKham = chkTaiKham.IsChecked.ToString();
            string NamSinh = txtNamSinh.Text;
            string GioiTinh = lstGioiTinh.SelectedValue != null ? lstGioiTinh.SelectedValue.ToString() : "";
            string DiaChi = txtDiaChi.Text;
            string TamTru = txtTamTru.Text;
            string XayRaNgay = dpXayRaNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpXayRaNgay.SelectedDate.Value) : "";
            string Tai = txtTai.Text;
            string TrinhDoVanHoa = txtTrinhDoVanHoa.Text;
            string DanToc = txtDanToc.Text;
            string TonGiao = txtTonGiao.Text;
            string NgheNghiep = txtNgheNghiep.Text;
            string DienThoai = txtDienThoai.Text;
            string DieuTraVien = txtDieuTraVien.Text;
            string DienThoaiDTV = txtDienThoaiDTV.Text;
            string GiayQDTCGD = chkGiayQDTCGD.IsChecked.ToString();
            string GiayCNTT = chkGiayCNTT.IsChecked.ToString();
            string YChung = chkYChung.IsChecked.ToString();
            string GiayRaVien = chkGiayRaVien.IsChecked.ToString();
            string ToaThuoc = chkToaThuoc.IsChecked.ToString();
            string SoKhamBenh = chkSoKhamBenh.IsChecked.ToString();
            string GiayXacNhanNamVien = chkGiayXacNhanNamVien.IsChecked.ToString();
            string BenhAnTomTat = chkBenhAnTomTat.IsChecked.ToString();
            string Khac = txtKhac.Text;
            string TT = chkTT.IsChecked.ToString();
            string SK = chkSK.IsChecked.ToString();
            string YC = chkYC.IsChecked.ToString();
            string DT = chkDT.IsChecked.ToString();
            string QHS = chkQHS.IsChecked.ToString();
            string TD = chkTD.IsChecked.ToString();
            string NguoiNhanHoSo = txtNguoiNhanHoSo.Text;
            string TongSoKhamChuyenKhoa = txtTongSoKhamChuyenKhoa.Text;
            string MaLoaiHSTTKT = cbbLoaiHS.SelectedValue != null ? cbbLoaiHS.SelectedValue.ToString() : "";

            string error = "";
            if (string.IsNullOrEmpty(GioiTinh))
            {
                error += "Chọn giới tính. \n";
            }
            if (string.IsNullOrEmpty(MaLoaiHSTTKT))
            {
                error += "Chọn loại hồ sơ. \n";
            }
            if (string.IsNullOrEmpty(error))
            {
                TableHoSo tblHS = new TableHoSo();
                string row_index = tblHS.insert_hoso(
                    SoHoSo,
                    QDTCGDSo,
                    CoQuanTrungCau,
                    KyNgay,
                    HoTen,
                    HinhDuongSu,
                    QuocTich,
                    NgayDenLamHoSo,
                    TaiKham,
                    NamSinh,
                    GioiTinh,
                    DiaChi,
                    TamTru,
                    XayRaNgay,
                    Tai,
                    TrinhDoVanHoa,
                    DanToc,
                    TonGiao,
                    NgheNghiep,
                    DienThoai,
                    DieuTraVien,
                    DienThoaiDTV,
                    GiayQDTCGD,
                    GiayCNTT,
                    YChung,
                    GiayRaVien,
                    ToaThuoc,
                    SoKhamBenh,
                    GiayXacNhanNamVien,
                    BenhAnTomTat,
                    Khac,
                    TT,
                    SK,
                    YC,
                    DT,
                    QHS,
                    TD,
                    NguoiNhanHoSo,
                    TongSoKhamChuyenKhoa,
                    MaLoaiHSTTKT
                    );
                dshs.RefreshData();
                int rowIndex = int.Parse(row_index);
                dshs.dataGrid1.CurrentPageIndex = Int32.Parse((rowIndex / dshs.dataGrid1.PageSize).ToString());
                dshs.dataGrid1.SelectRow(rowIndex);
                this.Close();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Thêm hồ sơ thương tích/khám trinh", tblMaHoSo.Text, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        //public byte[] getJPGFromImageControl(BitmapImage imageC)
        //{
        //    MemoryStream memStream = new MemoryStream();
        //    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
        //    encoder.Frames.Add(BitmapFrame.Create(imageC));
        //    encoder.Save(memStream);
        //    return memStream.GetBuffer();
        //}
        public byte[] getJPGFromImageControl(BitmapImage imageC, int imageWidth)
        {
            MemoryStream memStream;
            JpegBitmapEncoder encoder;
            memStream = new MemoryStream();
            encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);

            var result = new BitmapImage();
            result.BeginInit();
            result.DecodePixelWidth = imageWidth;
            result.StreamSource = new MemoryStream(memStream.GetBuffer());
            result.CreateOptions = BitmapCreateOptions.None;
            result.CacheOption = BitmapCacheOption.Default;
            result.EndInit();
            memStream.Close();
            memStream = new MemoryStream();
            encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(result));
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
            string MaHoSo = tblMaHoSo.Text;
            string SoHoSo = txtSoHoSo.Text;
            string QDTCGDSo = txtQDTCGDSo.Text;
            string CoQuanTrungCau = txtCoQuanTrungCau.Text;
            string KyNgay = dpKyNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpKyNgay.SelectedDate.Value) : "";
            string HoTen = txtHoTen.Text;
            byte[] HinhDuongSu = !string.IsNullOrEmpty(tblCheckImageStatus.Text) ? getJPGFromImageControl(((BitmapImage)imgHinhDuongSu.Source), 150) : new byte[0];
            string QuocTich = txtQuocTich.Text;
            string NgayDenLamHoSo = dpNgayDenLamHoSo.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpNgayDenLamHoSo.SelectedDate.Value) : "";
            string TaiKham = chkTaiKham.IsChecked.ToString();
            string NamSinh = txtNamSinh.Text;
            string GioiTinh = lstGioiTinh.SelectedValue.ToString();
            string DiaChi = txtDiaChi.Text;
            string TamTru = txtTamTru.Text;
            string XayRaNgay = dpXayRaNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpXayRaNgay.SelectedDate.Value) : "";
            string Tai = txtTai.Text;
            string TrinhDoVanHoa = txtTrinhDoVanHoa.Text;
            string DanToc = txtDanToc.Text;
            string TonGiao = txtTonGiao.Text;
            string NgheNghiep = txtNgheNghiep.Text;
            string DienThoai = txtDienThoai.Text;
            string DieuTraVien = txtDieuTraVien.Text;
            string DienThoaiDTV = txtDienThoaiDTV.Text;
            string GiayQDTCGD = chkGiayQDTCGD.IsChecked.ToString();
            string GiayCNTT = chkGiayCNTT.IsChecked.ToString();
            string YChung = chkYChung.IsChecked.ToString();
            string GiayRaVien = chkGiayRaVien.IsChecked.ToString();
            string ToaThuoc = chkToaThuoc.IsChecked.ToString();
            string SoKhamBenh = chkSoKhamBenh.IsChecked.ToString();
            string GiayXacNhanNamVien = chkGiayXacNhanNamVien.IsChecked.ToString();
            string BenhAnTomTat = chkBenhAnTomTat.IsChecked.ToString();
            string Khac = txtKhac.Text;
            string TT = chkTT.IsChecked.ToString();
            string SK = chkSK.IsChecked.ToString();
            string YC = chkYC.IsChecked.ToString();
            string DT = chkDT.IsChecked.ToString();
            string QHS = chkQHS.IsChecked.ToString();
            string TD = chkTD.IsChecked.ToString();
            string NguoiNhanHoSo = txtNguoiNhanHoSo.Text;
            string TongSoKhamChuyenKhoa = txtTongSoKhamChuyenKhoa.Text;
            string MaLoaiHSTTKT = cbbLoaiHS.SelectedValue != null ? cbbLoaiHS.SelectedValue.ToString() : "";

            TableHoSo tblHS = new TableHoSo();
            string row_index = tblHS.update_hoso(
                MaHoSo,
                SoHoSo,
                QDTCGDSo,
                CoQuanTrungCau,
                KyNgay,
                HoTen,
                HinhDuongSu,
                QuocTich,
                NgayDenLamHoSo,
                TaiKham,
                NamSinh,
                GioiTinh,
                DiaChi,
                TamTru,
                XayRaNgay,
                Tai,
                TrinhDoVanHoa,
                DanToc,
                TonGiao,
                NgheNghiep,
                DienThoai,
                DieuTraVien,
                DienThoaiDTV,
                GiayQDTCGD,
                GiayCNTT,
                YChung,
                GiayRaVien,
                ToaThuoc,
                SoKhamBenh,
                GiayXacNhanNamVien,
                BenhAnTomTat,
                Khac,
                TT,
                SK,
                YC,
                DT,
                QHS,
                TD,
                NguoiNhanHoSo,
                TongSoKhamChuyenKhoa,
                MaLoaiHSTTKT
                );
            dshs.RefreshData();
            int rowIndex = int.Parse(row_index);
            dshs.dataGrid1.CurrentPageIndex = Int32.Parse((rowIndex / dshs.dataGrid1.PageSize).ToString());
            dshs.dataGrid1.SelectRow(rowIndex);
            this.Close();
            App.ThemHanhDong(MainWindow._MaNhanVien, "Sửa hồ sơ thương tích/khám trinh", tblMaHoSo.Text, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xoá dòng này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
            {
                App.ThemHanhDong(MainWindow._MaNhanVien, "Xoá hồ sơ thương tích/khám trinh", tblMaHoSo.Text, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
                TableHoSo tblHS = new TableHoSo();
                tblHS.delete_hoso(tblMaHoSo.Text);
                dshs.dataGrid1.DeleteRow(dshs.dataGrid1.SelectedRow);
            }
        }

    }
}
