using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PhapY.App_Code
{
    public class TableTuThi
    {
        string connectionString = Common.ConnectionString;
        SqlDateTime sqlnull = SqlDateTime.Null;
        public DataView get_tuthi()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_tuthi_by_id(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_tuthi_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_tuthi_last()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_tuthi_last", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public int insert_tuthi(
                string SoHoSo,
                string QDTCGDSo,
		        string CoQuanTrungCau,
                string TinhThanh,
		        string KyNgay,
		        string HoTen,
                string HoTen1,
                string NamSinh,
                string GioiTinh,
		        string DiaChi,
		        byte[] HinhDuongSu,
		        string QuocTich,
		        string NguoiGiamDinh,
		        string NgayBatDau,
		        string NgayKetThuc,
		        string DieuTraVien,
		        string DienThoaiDTV,
		        string DiaDiemGiamDinh,
		        string DieuKienAnhSangThoiTiet,
		        string NguoiChungKien,
		        string NoiDungSuViec,
		        string TienSuCaNhan,
		        string NhanDangVaTinhTrangTuThi,
		        string CacDauVetThuongTich,
		        string KhamTrong,
		        string SoViThe1,
		        string SoViThe2,
		        string XetNghiemTeBao_MoBenhHoc,
		        string CacXetNghiemKhac,
                string ChanDoanYPhap,
		        string NguyenNhanChet,
		        string PhuMo1,
		        string PhuMo2,
		        string GiamDinhVien1,
		        string GiamDinhVien2,
                string TrinhDoVanHoa,
                string DanToc,
                string TonGiao,
                string NgheNghiep,
                string XayRa,
                string Tai,
                string KetQuaCanLamSang,
                string KetLuanKhac,
                string DocChat,
                string ADN,
                string HoSoTaiLieu,
                string NoiDungYeuCau,
                string NghienCuuHoSoBenhAn
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SoHoSo", SoHoSo);
            cmd.Parameters.AddWithValue("@QDTCGDSo", QDTCGDSo);
            cmd.Parameters.AddWithValue("@CoQuanTrungCau", CoQuanTrungCau);
            cmd.Parameters.AddWithValue("@TinhThanh", TinhThanh);
            cmd.Parameters.AddWithValue("@KyNgay", !string.IsNullOrEmpty(KyNgay) ? (object)KyNgay : sqlnull);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@HinhDuongSu", HinhDuongSu);
            cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayBatDau", !string.IsNullOrEmpty(NgayBatDau) ? (object)NgayBatDau : sqlnull);
            cmd.Parameters.AddWithValue("@NgayKetThuc", !string.IsNullOrEmpty(NgayKetThuc) ? (object)NgayKetThuc : sqlnull);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@DieuKienAnhSangThoiTiet", DieuKienAnhSangThoiTiet);
            cmd.Parameters.AddWithValue("@NguoiChungKien", NguoiChungKien);
            cmd.Parameters.AddWithValue("@NoiDungSuViec", NoiDungSuViec);
            cmd.Parameters.AddWithValue("@TienSuCaNhan", TienSuCaNhan);
            cmd.Parameters.AddWithValue("@NhanDangVaTinhTrangTuThi", NhanDangVaTinhTrangTuThi);
            cmd.Parameters.AddWithValue("@CacDauVetThuongTich", CacDauVetThuongTich);
            cmd.Parameters.AddWithValue("@KhamTrong", KhamTrong);
            cmd.Parameters.AddWithValue("@SoViThe1", SoViThe1);
            cmd.Parameters.AddWithValue("@SoViThe2", SoViThe2);
            cmd.Parameters.AddWithValue("@XetNghiemTeBao_MoBenhHoc", XetNghiemTeBao_MoBenhHoc);
            cmd.Parameters.AddWithValue("@CacXetNghiemKhac", CacXetNghiemKhac);
            cmd.Parameters.AddWithValue("@ChanDoanYPhap", ChanDoanYPhap);
            cmd.Parameters.AddWithValue("@NguyenNhanChet", NguyenNhanChet);
            cmd.Parameters.AddWithValue("@PhuMo1", PhuMo1);
            cmd.Parameters.AddWithValue("@PhuMo2", PhuMo2);
            cmd.Parameters.AddWithValue("@GiamDinhVien1", GiamDinhVien1);
            cmd.Parameters.AddWithValue("@GiamDinhVien2", GiamDinhVien2);
            cmd.Parameters.AddWithValue("@TrinhDoVanHoa", TrinhDoVanHoa);
            cmd.Parameters.AddWithValue("@DanToc", DanToc);
            cmd.Parameters.AddWithValue("@TonGiao", TonGiao);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@XayRa", XayRa);
            cmd.Parameters.AddWithValue("@Tai", Tai);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);
            cmd.Parameters.AddWithValue("@KetLuanKhac", KetLuanKhac);
            cmd.Parameters.AddWithValue("@DocChat", DocChat);
            cmd.Parameters.AddWithValue("@ADN", ADN);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }
        
        public int update_tuthi(
                string MaHoSo,
                string SoHoSo,
                string QDTCGDSo,
                string CoQuanTrungCau,
                string TinhThanh,
                string KyNgay,
                string HoTen,
                string HoTen1,
                string NamSinh,
                string GioiTinh,
                string DiaChi,
                byte[] HinhDuongSu,
                string QuocTich,
                string NguoiGiamDinh,
                string NgayBatDau,
                string NgayKetThuc,
                string DieuTraVien,
                string DienThoaiDTV,
                string DiaDiemGiamDinh,
                string DieuKienAnhSangThoiTiet,
                string NguoiChungKien,
                string NoiDungSuViec,
                string TienSuCaNhan,
                string NhanDangVaTinhTrangTuThi,
                string CacDauVetThuongTich,
                string KhamTrong,
                string SoViThe1,
                string SoViThe2,
                string XetNghiemTeBao_MoBenhHoc,
                string CacXetNghiemKhac,
                string ChanDoanYPhap,
                string NguyenNhanChet,
                string PhuMo1,
                string PhuMo2,
                string GiamDinhVien1,
                string GiamDinhVien2,
                string TrinhDoVanHoa,
                string DanToc,
                string TonGiao,
                string NgheNghiep,
                string XayRa,
                string Tai,
                string KetQuaCanLamSang,                
                string KetLuanKhac,
                string DocChat,
                string ADN,
                string HoSoTaiLieu,
                string NoiDungYeuCau,
                string NghienCuuHoSoBenhAn
           )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@SoHoSo", SoHoSo);
            cmd.Parameters.AddWithValue("@QDTCGDSo", QDTCGDSo);
            cmd.Parameters.AddWithValue("@CoQuanTrungCau", CoQuanTrungCau);
            cmd.Parameters.AddWithValue("@TinhThanh", TinhThanh);
            cmd.Parameters.AddWithValue("@KyNgay", !string.IsNullOrEmpty(KyNgay) ? (object)KyNgay : sqlnull);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@HinhDuongSu", HinhDuongSu);
            cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayBatDau", !string.IsNullOrEmpty(NgayBatDau) ? (object)NgayBatDau : sqlnull);
            cmd.Parameters.AddWithValue("@NgayKetThuc", !string.IsNullOrEmpty(NgayKetThuc) ? (object)NgayKetThuc : sqlnull);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@DieuKienAnhSangThoiTiet", DieuKienAnhSangThoiTiet);
            cmd.Parameters.AddWithValue("@NguoiChungKien", NguoiChungKien);
            cmd.Parameters.AddWithValue("@NoiDungSuViec", NoiDungSuViec);
            cmd.Parameters.AddWithValue("@TienSuCaNhan", TienSuCaNhan);
            cmd.Parameters.AddWithValue("@NhanDangVaTinhTrangTuThi", NhanDangVaTinhTrangTuThi);
            cmd.Parameters.AddWithValue("@CacDauVetThuongTich", CacDauVetThuongTich);
            cmd.Parameters.AddWithValue("@KhamTrong", KhamTrong);
            cmd.Parameters.AddWithValue("@SoViThe1", SoViThe1);
            cmd.Parameters.AddWithValue("@SoViThe2", SoViThe2);
            cmd.Parameters.AddWithValue("@XetNghiemTeBao_MoBenhHoc", XetNghiemTeBao_MoBenhHoc);
            cmd.Parameters.AddWithValue("@CacXetNghiemKhac", CacXetNghiemKhac);
            cmd.Parameters.AddWithValue("@ChanDoanYPhap", ChanDoanYPhap);
            cmd.Parameters.AddWithValue("@NguyenNhanChet", NguyenNhanChet);
            cmd.Parameters.AddWithValue("@PhuMo1", PhuMo1);
            cmd.Parameters.AddWithValue("@PhuMo2", PhuMo2);
            cmd.Parameters.AddWithValue("@GiamDinhVien1", GiamDinhVien1);
            cmd.Parameters.AddWithValue("@GiamDinhVien2", GiamDinhVien2);
            cmd.Parameters.AddWithValue("@TrinhDoVanHoa", TrinhDoVanHoa);
            cmd.Parameters.AddWithValue("@DanToc", DanToc);
            cmd.Parameters.AddWithValue("@TonGiao", TonGiao);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@XayRa", XayRa);
            cmd.Parameters.AddWithValue("@Tai", Tai);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);
            cmd.Parameters.AddWithValue("@KetLuanKhac", KetLuanKhac);
            cmd.Parameters.AddWithValue("@DocChat", DocChat);
            cmd.Parameters.AddWithValue("@ADN", ADN);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);


            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public void delete_tuthi(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

        public void update_hosotuthidangophong(string MaHoSo, string DangOPhong)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_hosotuthidangophong", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@DangOPhong", DangOPhong);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public void khoahoso_tuthi(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("khoahoso_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public void mokhoakhoahoso_tuthi(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("mokhoakhoahoso_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public DataView thongke_tuthi_theo_thang(string Month)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("thongke_tuthi_theo_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Month", Month);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView bieu_do_thongke_tuthi_theo_thang()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("bieu_do_thongke_tuthi_theo_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView thongke_tuthi_theo_ngay_thang(string startdate, string enddate)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("thongke_tuthi_theo_ngay_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@enddate", enddate);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
    }
}
