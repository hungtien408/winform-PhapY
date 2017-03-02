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
using PhapY.SubWindows;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for ThemTuThi.xaml
    /// </summary>
    public partial class ThemTuThi : UserControl
    {
        string _MaHoSo;
        DataView dv;
        DanhSachHoSoTuThi _dshstt;
        static int i = 1;
        public ThemTuThi()
        {
            InitializeComponent();
            btnEdit.Visibility = Visibility.Collapsed;
            btnDel.Visibility = Visibility.Collapsed;
            i = 1;
        }
        public ThemTuThi(DanhSachHoSoTuThi dshstt, string MaHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            _dshstt = dshstt;
            i = 1;
            LoadData();
        }
        private void LoadData()
        {
            TableTuThi tblKLTT = new TableTuThi();
            dv = tblKLTT.get_tuthi_by_id(_MaHoSo);
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                _MaHoSo = dv[0]["MaHoSo"].ToString();
                btnAdd.Visibility = Visibility.Collapsed;
                btnEdit.Visibility = Visibility.Visible;
                btnDel.Visibility = Visibility.Visible;

                lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
                lblThang.Content = string.Format("{0:MM}", DateTime.Now);
                lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);

                //if (bool.Parse(dv[0]["TinhTrangHoSo"].ToString()))
                //{
                //    btnEdit.Visibility = Visibility.Collapsed;
                //    btnDel.Visibility = Visibility.Collapsed;
                //}
                //else
                //{
                //    btnEdit.Visibility = Visibility.Visible;
                //    btnDel.Visibility = Visibility.Visible;
                //}
                
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DiaDiemGiamDinh");
                dt.Columns.Add("QuocTich");
                dt.Columns.Add("CoQuanTrungCau");
                dt.Columns.Add("TrinhDoVanHoa");
                dt.Columns.Add("DanToc");
                dt.Columns.Add("TonGiao");
                dt.Columns.Add("NgheNghiep");
                DataRow dr = dt.NewRow();
                dr["DiaDiemGiamDinh"] = ", trong điều kiện thuận lợi.";
                dr["QuocTich"] = "Việt Nam";
                dr["CoQuanTrungCau"] = "- Tp.Hồ Chí Minh.";
                dr["TrinhDoVanHoa"] = "Không được cung cấp";
                dr["DanToc"] = "Không được cung cấp";
                dr["TonGiao"] = "Không được cung cấp";
                dr["NgheNghiep"] = "Không được cung cấp";
                dt.Rows.Add(dr);
                Container.DataContext = dt.DefaultView[0];
                btnAdd.Visibility = Visibility.Visible;
                btnEdit.Visibility = Visibility.Collapsed;
                btnDel.Visibility = Visibility.Collapsed;

                lblNgay.Content = DateTime.Now.ToString("dd");
                lblThang.Content = DateTime.Now.ToString("MM");
                lblNam.Content = DateTime.Now.ToString("yyyy");
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
            string SoHoSo = txtSoHoSo.Text.TrimEnd();
            string QDTCGDSo = txtQDTCGDSo.Text.TrimEnd();
            string CoQuanTrungCau = txtCoQuanTrungCau.Text.TrimEnd();
            string TinhThanh = "";// txtTinhThanh.Text;
            string KyNgay = dpKyNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpKyNgay.SelectedDate.Value) : "";
            string HoTen = txtHoTen.Text.TrimEnd();
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string NamSinh = txtNamSinh.Text.TrimEnd();
            string GioiTinh = lstGioiTinh.SelectedValue != null ? lstGioiTinh.SelectedValue.ToString() : "";
            string DiaChi = txtDiaChi.Text.TrimEnd();
            byte[] HinhDuongSu = imgHinhDuongSu.Source != null ? getJPGFromImageControl(((BitmapImage)imgHinhDuongSu.Source), 150) : new byte[0];
            //byte[] HinhDuongSu = new byte[0];
            string QuocTich = txtQuocTich.Text.TrimEnd();
		    string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
		    string NgayBatDau = dpNgayBatDau.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayBatDau.SelectedDate.Value) + GioPhutBatDau : "";
		    string NgayKetThuc = dpNgayKetThuc.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayKetThuc.SelectedDate.Value) + GioPhutKetThuc : "";
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string DieuKienAnhSangThoiTiet = "";// txtDieuKienAnhSangThoiTiet.Text.TrimEnd();
            string NguoiChungKien = txtNguoiChungKien.Text.TrimEnd();
            string NoiDungSuViec = txtNoiDungSuViec.Text.TrimEnd();
            string TienSuCaNhan = txtTienSuCaNhan.Text.TrimEnd();
            string NhanDangVaTinhTrangTuThi = txtNhanDangVaTinhTrangTuThi.Text.TrimEnd();
            string CacDauVetThuongTich = txtCacDauVetThuongTich.Text.TrimEnd();
            string KhamTrong = txtKhamTrong.Text.TrimEnd();
            string SoViThe1 = "";// txtSoViThe1.Text;
            string SoViThe2 = "";// txtSoViThe2.Text;
            string XetNghiemTeBao_MoBenhHoc = "";// txtXetNghiemTeBao_MoBenhHoc.Text.TrimEnd();
            string CacXetNghiemKhac = "";// txtCacXetNghiemKhac.Text.TrimEnd();
            string ChanDoanYPhap =  txtChanDoanYPhap.Text.TrimEnd();
            string NguyenNhanChet = txtNguyenNhanChet.Text.TrimEnd();
            string PhuMo1 = txtPhuMo1.Text.TrimEnd();
            string PhuMo2 = txtPhuMo2.Text.TrimEnd();
            string GiamDinhVien1 = txtGiamDinhVien1.Text.TrimEnd();
            string GiamDinhVien2 = txtGiamDinhVien2.Text.TrimEnd();
            string TrinhDoVanHoa = txtTrinhDoVanHoa.Text.TrimEnd();
            string DanToc = txtDanToc.Text.TrimEnd();
            string TonGiao = txtTonGiao.Text.TrimEnd();
            string NgheNghiep = txtNgheNghiep.Text.TrimEnd();
            string XayRa = txtXayRa.Text.TrimEnd();
            string Tai = txtTai.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();
            string KetLuanKhac = txtKetLuanKhac.Text.TrimEnd();
            string DocChat = "";// txtDocChat.Text;
            string ADN = "";// txtADN.Text;
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();


            if (string.IsNullOrEmpty(GioiTinh))
                error += "- Chọn giới tính. \n";
            //if (string.IsNullOrEmpty(KyNgay))
            //    error += "- Nhập ký ngày!\n";
            //if (string.IsNullOrEmpty(NgayBatDau))
            //    error += "- Nhập ngày giờ bắt đầu giám định!\n";
            //if (string.IsNullOrEmpty(NgayKetThuc))
            //    error += "- Nhập ngày giờ kết thúc giám định!\n";

            if (string.IsNullOrEmpty(error))
            {

                TableTuThi tblKLTT = new TableTuThi();
                tblKLTT.insert_tuthi(
                    SoHoSo,
                    QDTCGDSo,
		            CoQuanTrungCau,
                    TinhThanh,
		            KyNgay,
		            HoTen,
                    HoTen1,
                    NamSinh,
                    GioiTinh,
		            DiaChi,
		            HinhDuongSu,
		            QuocTich,
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
                    ChanDoanYPhap,
		            NguyenNhanChet,
		            PhuMo1,
		            PhuMo2,
		            GiamDinhVien1,
		            GiamDinhVien2,
                    TrinhDoVanHoa,
                    DanToc,
                    TonGiao,
                    NgheNghiep,
                    XayRa,
                    Tai,
                    KetQuaCanLamSang,
                    KetLuanKhac,
                    DocChat,
                    ADN,
                    HoSoTaiLieu,
                    NoiDungYeuCau,
                    NghienCuuHoSoBenhAn
                    );

                MessageBox.Show("Thêm thành công.");
                LoadData();
                _dshstt.RefreshData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Thêm hồ sơ tử thi.", _MaHoSo, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
            }
            else
            {
                MessageBox.Show(error);
            }

        }
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
            string error = "",
                GioBatDau = txtGioPhutBatDau.Hours != "" ? txtGioPhutBatDau.Hours : "00",
                PhutBatDau = txtGioPhutBatDau.Minutes != "" ? txtGioPhutBatDau.Minutes : "00",
                GioPhutBatDau = GioBatDau + ":" + PhutBatDau,
                GioKetThuc = txtGioPhutKetThuc.Hours != "" ? txtGioPhutKetThuc.Hours : "00",
                PhutKetThuc = txtGioPhutKetThuc.Minutes != "" ? txtGioPhutKetThuc.Minutes : "00",
                GioPhutKetThuc = GioKetThuc + ":" + PhutKetThuc;

            string MaHoSo = _MaHoSo;
            string SoHoSo = txtSoHoSo.Text.TrimEnd();
            string QDTCGDSo = txtQDTCGDSo.Text.TrimEnd();
            string CoQuanTrungCau = txtCoQuanTrungCau.Text.TrimEnd();
            string TinhThanh = "";// txtTinhThanh.Text;
            string KyNgay = dpKyNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpKyNgay.SelectedDate.Value) : "";
            string HoTen = txtHoTen.Text.TrimEnd();
            string HoTen1 = txtHoTen1.Text.TrimEnd();
            string NamSinh = txtNamSinh.Text.TrimEnd();
            string GioiTinh = lstGioiTinh.SelectedValue != null ? lstGioiTinh.SelectedValue.ToString() : "";
            string DiaChi = txtDiaChi.Text.TrimEnd();
            byte[] HinhDuongSu = !string.IsNullOrEmpty(tblCheckImageStatus.Text) ? getJPGFromImageControl(((BitmapImage)imgHinhDuongSu.Source), 150) : new byte[0];
            //byte[] HinhDuongSu = new byte[0];
            string QuocTich = txtQuocTich.Text.TrimEnd();
            string NguoiGiamDinh = txtNguoiGiamDinh.Text.TrimEnd();
            string NgayBatDau = dpNgayBatDau.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayBatDau.SelectedDate.Value) + GioPhutBatDau : "";
            string NgayKetThuc = dpNgayKetThuc.SelectedDate != null ? string.Format("{0:MM/dd/yyyy }", dpNgayKetThuc.SelectedDate.Value) + GioPhutKetThuc : "";
            string DieuTraVien = "";// txtDieuTraVien.Text;
            string DienThoaiDTV = "";// txtDienThoaiDTV.Text;
            string DiaDiemGiamDinh = txtDiaDiemGiamDinh.Text.TrimEnd();
            string DieuKienAnhSangThoiTiet = "";// txtDieuKienAnhSangThoiTiet.Text.TrimEnd();
            string NguoiChungKien = txtNguoiChungKien.Text.TrimEnd();
            string NoiDungSuViec = txtNoiDungSuViec.Text.TrimEnd();
            string TienSuCaNhan = txtTienSuCaNhan.Text.TrimEnd();
            string NhanDangVaTinhTrangTuThi = txtNhanDangVaTinhTrangTuThi.Text.TrimEnd();
            string CacDauVetThuongTich = txtCacDauVetThuongTich.Text.TrimEnd();
            string KhamTrong = txtKhamTrong.Text.TrimEnd();
            string SoViThe1 = "";// txtSoViThe1.Text;
            string SoViThe2 = "";// txtSoViThe2.Text;
            string XetNghiemTeBao_MoBenhHoc = "";// txtXetNghiemTeBao_MoBenhHoc.Text.TrimEnd();
            string CacXetNghiemKhac = "";// txtCacXetNghiemKhac.Text.TrimEnd();
            string ChanDoanYPhap = txtChanDoanYPhap.Text.TrimEnd();
            string NguyenNhanChet = txtNguyenNhanChet.Text.TrimEnd();
            string PhuMo1 = txtPhuMo1.Text.TrimEnd();
            string PhuMo2 = txtPhuMo2.Text.TrimEnd();
            string GiamDinhVien1 = txtGiamDinhVien1.Text.TrimEnd();
            string GiamDinhVien2 = txtGiamDinhVien2.Text.TrimEnd();
            string TrinhDoVanHoa = txtTrinhDoVanHoa.Text.TrimEnd();
            string DanToc = txtDanToc.Text.TrimEnd();
            string TonGiao = txtTonGiao.Text.TrimEnd();
            string NgheNghiep = txtNgheNghiep.Text.TrimEnd();
            string XayRa = txtXayRa.Text.TrimEnd();
            string Tai = txtTai.Text.TrimEnd();
            string KetQuaCanLamSang = txtKetQuaCanLamSang.Text.TrimEnd();
            string KetLuanKhac = txtKetLuanKhac.Text.TrimEnd();
            string DocChat = "";// txtDocChat.Text;
            string ADN = "";// txtADN.Text;
            string HoSoTaiLieu = txtHoSoTaiLieu.Text.TrimEnd();
            string NoiDungYeuCau = txtNoiDungYeuCau.Text.TrimEnd();
            string NghienCuuHoSoBenhAn = txtNghienCuuHoSoBenhAn.Text.TrimEnd();

          
            //if (string.IsNullOrEmpty(KyNgay))
            //    error += "- Nhập ký ngày!\n";
            //if (string.IsNullOrEmpty(NgayBatDau))
            //    error += "- Nhập ngày giờ bắt đầu giám định!\n";
            //if (string.IsNullOrEmpty(NgayKetThuc))
            //    error += "- Nhập ngày giờ kết thúc giám định!\n";

            if (string.IsNullOrEmpty(error))
            {

                TableTuThi tblKLTT = new TableTuThi();
                
                tblKLTT.update_tuthi(
                    _MaHoSo,
                    SoHoSo,
                    QDTCGDSo,
                    CoQuanTrungCau,
                    TinhThanh,
                    KyNgay,
                    HoTen,
                    HoTen1,
                    NamSinh,
                    GioiTinh,
                    DiaChi,
                    HinhDuongSu,
                    QuocTich,
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
                    ChanDoanYPhap,
                    NguyenNhanChet,
                    PhuMo1,
                    PhuMo2,
                    GiamDinhVien1,
                    GiamDinhVien2,
                    TrinhDoVanHoa,
                    DanToc,
                    TonGiao,
                    NgheNghiep,
                    XayRa,
                    Tai,
                    KetQuaCanLamSang,
                    KetLuanKhac,
                    DocChat,
                    ADN,
                    HoSoTaiLieu,
                    NoiDungYeuCau,
                    NghienCuuHoSoBenhAn
                    );
                
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
                _dshstt.RefreshData();
                App.ThemHanhDong(MainWindow._MaNhanVien, "Sửa hồ sơ tử thi.", _MaHoSo, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
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
                App.ThemHanhDong(MainWindow._MaNhanVien, "Xoá hồ sơ tử thi.", _MaHoSo, txtSoHoSo.Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), txtQDTCGDSo.Text);
                TableTuThi tblKLTT = new TableTuThi();
                tblKLTT.delete_tuthi(_MaHoSo);
                DataTable dt = dv.ToTable();
                dt.Clear();
                var dr = dt.NewRow();
                dt.Rows.Add(dr);
                Container.DataContext = dt.DefaultView[0];
                LoadData();
                _dshstt.RefreshData();
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
                    prefix = "" + i + ". ";
                }
                else
                {
                    prefix = prefix.Trim() + Environment.NewLine + i + ". ";
                }

                if (!string.IsNullOrEmpty(wdChonBS.SoThe))
                {
                    //txtNguoiGiamDinh.Text = prefix + (wdChonBS.TenNhanVien + "\t: Giám định viên số thẻ " + wdChonBS.SoThe + "/TP-GĐTP").Trim();
                    txtNguoiGiamDinh.Text = prefix + (wdChonBS.TenNhanVien + "\tGiám Định Viên\n\t\t\t\tSố thẻ: " + wdChonBS.SoThe + "/TP-GĐTP").Trim();
                }
                else
                {
                    txtNguoiGiamDinh.Text = prefix + (wdChonBS.TenNhanVien + "\t " + wdChonBS.ChucVu).Trim();
                }
            }
            i++;
        }

        private void txtHoTen_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHoTen1.Text = txtHoTen.Text;
        }
    }
}
