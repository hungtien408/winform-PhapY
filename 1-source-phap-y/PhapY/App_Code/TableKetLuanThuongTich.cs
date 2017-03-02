using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PhapY.App_Code
{
    public class TableKetLuanThuongTich
    {
        string connectionString = Common.ConnectionString;
        public DataView get_ketluanthuongtich()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluanthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluanthuongtich_by_id(string MaKetLuanThuongTich)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluanthuongtich_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanThuongTich", MaKetLuanThuongTich);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluanthuongtich_by_hoso(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluanthuongtich_by_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public int insert_ketluanthuongtich(
                string MaHoSo,
                string NgayGioGiamDinh,
                string NguoiGiamDinh,
                string VoiSuGiupDo,
                string DieuTraVien,
                string DienThoaiDTV,
                string TinhHinhSuViec,
                string NghienCuuHoSoTaiLieu,
                string ThaiDo,
                string ChieuCao,
                string CanNang,
                string Mach,
                string HuyetAp,
                string NhietDo,
                string NhipTho,
                string ThuongTich,
                string CanLamSang,
                string DauHieuChinhQuaGiamDinh,
                string SucKhoeGiam,
                string TamThoi,
                string TamThoiBangChu,
                string VinhVien,
                string VinhVienBangChu,
                string TomTatTinhHinhSuViec,
                string SucKhoeGiamBangChu,
                string HoTen1,
                string DiaDiemGiamDinh,
                string HoSoTaiLieu,
                string NoiDungYeuCau,
                string NghienCuuHoSoBenhAn,
                string TheTrang,
                string LamSang,
                string KhamChuyenKhoa,
                string KetQuaCanLamSang,
                string KetLuanKhac
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_ketluanthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NgayGioGiamDinh", NgayGioGiamDinh);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@VoiSuGiupDo", VoiSuGiupDo);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@TinhHinhSuViec", TinhHinhSuViec);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoTaiLieu", NghienCuuHoSoTaiLieu);
            cmd.Parameters.AddWithValue("@ThaiDo", ThaiDo);
            cmd.Parameters.AddWithValue("@ChieuCao", ChieuCao);
            cmd.Parameters.AddWithValue("@CanNang", CanNang);
            cmd.Parameters.AddWithValue("@Mach", Mach);
            cmd.Parameters.AddWithValue("@HuyetAp", HuyetAp);
            cmd.Parameters.AddWithValue("@NhietDo", NhietDo);
            cmd.Parameters.AddWithValue("@NhipTho", NhipTho);
            cmd.Parameters.AddWithValue("@ThuongTich", ThuongTich);
            cmd.Parameters.AddWithValue("@CanLamSang", CanLamSang);
            cmd.Parameters.AddWithValue("@DauHieuChinhQuaGiamDinh", DauHieuChinhQuaGiamDinh);
            cmd.Parameters.AddWithValue("@SucKhoeGiam", SucKhoeGiam);
            cmd.Parameters.AddWithValue("@TamThoi", TamThoi);
            cmd.Parameters.AddWithValue("@TamThoiBangChu", TamThoiBangChu);
            cmd.Parameters.AddWithValue("@VinhVien", VinhVien);
            cmd.Parameters.AddWithValue("@VinhVienBangChu", VinhVienBangChu);
            cmd.Parameters.AddWithValue("@TomTatTinhHinhSuViec", TomTatTinhHinhSuViec);
            cmd.Parameters.AddWithValue("@SucKhoeGiamBangChu", SucKhoeGiamBangChu);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);
            cmd.Parameters.AddWithValue("@TheTrang", TheTrang);
            cmd.Parameters.AddWithValue("@LamSang", LamSang);
            cmd.Parameters.AddWithValue("@KhamChuyenKhoa", KhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);
            cmd.Parameters.AddWithValue("@KetLuanKhac", KetLuanKhac);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public int update_ketluanthuongtich(
                string MaKetLuanThuongTich,
                string MaHoSo,
                string NgayGioGiamDinh,
                string NguoiGiamDinh,
                string VoiSuGiupDo,
                string DieuTraVien,
                string DienThoaiDTV,
                string TinhHinhSuViec,
                string NghienCuuHoSoTaiLieu,
                string ThaiDo,
                string ChieuCao,
                string CanNang,
                string Mach,
                string HuyetAp,
                string NhietDo,
                string NhipTho,
                string ThuongTich,
                string CanLamSang,
                string DauHieuChinhQuaGiamDinh,
                string SucKhoeGiam,
                string TamThoi,
                string TamThoiBangChu,
                string VinhVien,
                string VinhVienBangChu,
                string TomTatTinhHinhSuViec,
                string SucKhoeGiamBangChu,
                string HoTen1,
                string DiaDiemGiamDinh,
                string HoSoTaiLieu,
                string NoiDungYeuCau,
                string NghienCuuHoSoBenhAn,
                string TheTrang,
                string LamSang,
                string KhamChuyenKhoa,
                string KetQuaCanLamSang,
                string KetLuanKhac
           )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_ketluanthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanThuongTich", MaKetLuanThuongTich);
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NgayGioGiamDinh", NgayGioGiamDinh);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@VoiSuGiupDo", VoiSuGiupDo);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@TinhHinhSuViec", TinhHinhSuViec);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoTaiLieu", NghienCuuHoSoTaiLieu);
            cmd.Parameters.AddWithValue("@ThaiDo", ThaiDo);
            cmd.Parameters.AddWithValue("@ChieuCao", ChieuCao);
            cmd.Parameters.AddWithValue("@CanNang", CanNang);
            cmd.Parameters.AddWithValue("@Mach", Mach);
            cmd.Parameters.AddWithValue("@HuyetAp", HuyetAp);
            cmd.Parameters.AddWithValue("@NhietDo", NhietDo);
            cmd.Parameters.AddWithValue("@NhipTho", NhipTho);
            cmd.Parameters.AddWithValue("@ThuongTich", ThuongTich);
            cmd.Parameters.AddWithValue("@CanLamSang", CanLamSang);
            cmd.Parameters.AddWithValue("@DauHieuChinhQuaGiamDinh", DauHieuChinhQuaGiamDinh);
            cmd.Parameters.AddWithValue("@SucKhoeGiam", SucKhoeGiam);
            cmd.Parameters.AddWithValue("@TamThoi", TamThoi);
            cmd.Parameters.AddWithValue("@TamThoiBangChu", TamThoiBangChu);
            cmd.Parameters.AddWithValue("@VinhVien", VinhVien);
            cmd.Parameters.AddWithValue("@VinhVienBangChu", VinhVienBangChu);
            cmd.Parameters.AddWithValue("@TomTatTinhHinhSuViec", TomTatTinhHinhSuViec);
            cmd.Parameters.AddWithValue("@SucKhoeGiamBangChu", SucKhoeGiamBangChu);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);
            cmd.Parameters.AddWithValue("@TheTrang", TheTrang);
            cmd.Parameters.AddWithValue("@LamSang", LamSang);
            cmd.Parameters.AddWithValue("@KhamChuyenKhoa", KhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);
            cmd.Parameters.AddWithValue("@KetLuanKhac", KetLuanKhac);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public void delete_ketluanthuongtich(string MaKetLuanThuongTich)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_ketluanthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanThuongTich", MaKetLuanThuongTich);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
