using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PhapY.App_Code
{
    public class TableKetLuanTinhDuc
    {
        string connectionString = Common.ConnectionString;
        public DataView get_ketluantinhduc()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantinhduc", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluantinhduc_by_id(string MaKetLuanTinhDuc)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantinhduc_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTinhDuc", MaKetLuanTinhDuc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluantinhduc_by_hoso(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantinhduc_by_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public int insert_ketluantinhduc(
            string MaHoSo,
			string NguoiGiamDinh,
			string NgayGioGiamDinh,
			string VoiSuGiupDo,
			string DieuTraVien,
			string DienThoaiDTV,
			string TinhHinhSuViec,
			string NghienCuuHoSoTaiLieu,
			string LamSang,
			string ThaiDo,
			string ChieuCao,
			string CanNang,
			string HuyetAp,
			string Mach,
			string NhietDo,
			string QuanAo,
			string LongMu,
			string MoiLon,
			string MoiBe,
			string AmHo,
			string MangTrinh,
			string AmDao,
			string TangSinhMon,
			string HauMon,
			string Dau,
			string Co,
			string Nguc,
			string Dui,
			string Lung,
			string Mong,
			string TayChan,
			string MaSo,
			string LayMauPhetDichAmDao,
			string SoMauPhetDichAmDao,
			string Phodphatase,
			string Christmas,
			string LuuMauPhetDichAmDao,
			string LayMau,
			string QuetNiemMac,
			string SieuAmBung,
			string DauHieu,
            string KLKhac,
            string KhongThucHienPhodphatase,
            string KhongThucHienChristmas,
            string XetNghiemHIV,
            string HoTen1,
            string DiaDiemGiamDinh,
            string HoSoTaiLieu,
            string NoiDungYeuCau,
            string NghienCuuHoSoBenhAn,
            string TheTrang,
            string KhamChuyenKhoa,
            string KetQuaCanLamSang
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_ketluantinhduc", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayGioGiamDinh", NgayGioGiamDinh);
            cmd.Parameters.AddWithValue("@VoiSuGiupDo", VoiSuGiupDo);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@TinhHinhSuViec", TinhHinhSuViec);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoTaiLieu", NghienCuuHoSoTaiLieu);
            cmd.Parameters.AddWithValue("@LamSang", LamSang);
            cmd.Parameters.AddWithValue("@ThaiDo", ThaiDo);
            cmd.Parameters.AddWithValue("@ChieuCao", ChieuCao);
            cmd.Parameters.AddWithValue("@CanNang", CanNang);
            cmd.Parameters.AddWithValue("@HuyetAp", HuyetAp);
            cmd.Parameters.AddWithValue("@Mach", Mach);
            cmd.Parameters.AddWithValue("@NhietDo", NhietDo);
            cmd.Parameters.AddWithValue("@QuanAo", QuanAo);
            cmd.Parameters.AddWithValue("@LongMu", LongMu);
            cmd.Parameters.AddWithValue("@MoiLon", MoiLon);
            cmd.Parameters.AddWithValue("@MoiBe", MoiBe);
            cmd.Parameters.AddWithValue("@AmHo", AmHo);
            cmd.Parameters.AddWithValue("@MangTrinh", MangTrinh);
            cmd.Parameters.AddWithValue("@AmDao", AmDao);
            cmd.Parameters.AddWithValue("@TangSinhMon", TangSinhMon);
            cmd.Parameters.AddWithValue("@HauMon", HauMon);
            cmd.Parameters.AddWithValue("@Dau", Dau);
            cmd.Parameters.AddWithValue("@Co", Co);
            cmd.Parameters.AddWithValue("@Nguc", Nguc);
            cmd.Parameters.AddWithValue("@Dui", Dui);
            cmd.Parameters.AddWithValue("@Lung", Lung);
            cmd.Parameters.AddWithValue("@Mong", Mong);
            cmd.Parameters.AddWithValue("@TayChan", TayChan);
            cmd.Parameters.AddWithValue("@MaSo", MaSo);
            cmd.Parameters.AddWithValue("@LayMauPhetDichAmDao", LayMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@SoMauPhetDichAmDao", SoMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@Phodphatase", Phodphatase);
            cmd.Parameters.AddWithValue("@Christmas", Christmas);
            cmd.Parameters.AddWithValue("@LuuMauPhetDichAmDao", LuuMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@LayMau", LayMau);
            cmd.Parameters.AddWithValue("@QuetNiemMac", QuetNiemMac);
            cmd.Parameters.AddWithValue("@SieuAmBung", SieuAmBung);
            cmd.Parameters.AddWithValue("@DauHieu", DauHieu);
            cmd.Parameters.AddWithValue("@KLKhac", KLKhac);
            cmd.Parameters.AddWithValue("@KhongThucHienPhodphatase", KhongThucHienPhodphatase);
            cmd.Parameters.AddWithValue("@KhongThucHienChristmas", KhongThucHienChristmas);
            cmd.Parameters.AddWithValue("@XetNghiemHIV", XetNghiemHIV);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);
            cmd.Parameters.AddWithValue("@TheTrang", TheTrang);
            cmd.Parameters.AddWithValue("@KhamChuyenKhoa", KhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public int update_ketluantinhduc(
                string MaKetLuanTinhDuc,
                string MaHoSo,
            string NguoiGiamDinh,
            string NgayGioGiamDinh,
            string VoiSuGiupDo,
            string DieuTraVien,
            string DienThoaiDTV,
            string TinhHinhSuViec,
            string NghienCuuHoSoTaiLieu,
            string LamSang,
            string ThaiDo,
            string ChieuCao,
            string CanNang,
            string HuyetAp,
            string Mach,
            string NhietDo,
            string QuanAo,
            string LongMu,
            string MoiLon,
            string MoiBe,
            string AmHo,
            string MangTrinh,
            string AmDao,
            string TangSinhMon,
            string HauMon,
            string Dau,
            string Co,
            string Nguc,
            string Dui,
            string Lung,
            string Mong,
            string TayChan,
            string MaSo,
            string LayMauPhetDichAmDao,
            string SoMauPhetDichAmDao,
            string Phodphatase,
            string Christmas,
            string LuuMauPhetDichAmDao,
            string LayMau,
            string QuetNiemMac,
            string SieuAmBung,
            string DauHieu,
            string KLKhac,
            string KhongThucHienPhodphatase,
            string KhongThucHienChristmas,
            string XetNghiemHIV,
            string HoTen1,
            string DiaDiemGiamDinh,
            string HoSoTaiLieu,
            string NoiDungYeuCau,
            string NghienCuuHoSoBenhAn,
            string TheTrang,
            string KhamChuyenKhoa,
            string KetQuaCanLamSang
           )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_ketluantinhduc", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTinhDuc", MaKetLuanTinhDuc);
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayGioGiamDinh", NgayGioGiamDinh);
            cmd.Parameters.AddWithValue("@VoiSuGiupDo", VoiSuGiupDo);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@TinhHinhSuViec", TinhHinhSuViec);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoTaiLieu", NghienCuuHoSoTaiLieu);
            cmd.Parameters.AddWithValue("@LamSang", LamSang);
            cmd.Parameters.AddWithValue("@ThaiDo", ThaiDo);
            cmd.Parameters.AddWithValue("@ChieuCao", ChieuCao);
            cmd.Parameters.AddWithValue("@CanNang", CanNang);
            cmd.Parameters.AddWithValue("@HuyetAp", HuyetAp);
            cmd.Parameters.AddWithValue("@Mach", Mach);
            cmd.Parameters.AddWithValue("@NhietDo", NhietDo);
            cmd.Parameters.AddWithValue("@QuanAo", QuanAo);
            cmd.Parameters.AddWithValue("@LongMu", LongMu);
            cmd.Parameters.AddWithValue("@MoiLon", MoiLon);
            cmd.Parameters.AddWithValue("@MoiBe", MoiBe);
            cmd.Parameters.AddWithValue("@AmHo", AmHo);
            cmd.Parameters.AddWithValue("@MangTrinh", MangTrinh);
            cmd.Parameters.AddWithValue("@AmDao", AmDao);
            cmd.Parameters.AddWithValue("@TangSinhMon", TangSinhMon);
            cmd.Parameters.AddWithValue("@HauMon", HauMon);
            cmd.Parameters.AddWithValue("@Dau", Dau);
            cmd.Parameters.AddWithValue("@Co", Co);
            cmd.Parameters.AddWithValue("@Nguc", Nguc);
            cmd.Parameters.AddWithValue("@Dui", Dui);
            cmd.Parameters.AddWithValue("@Lung", Lung);
            cmd.Parameters.AddWithValue("@Mong", Mong);
            cmd.Parameters.AddWithValue("@TayChan", TayChan);
            cmd.Parameters.AddWithValue("@MaSo", MaSo);
            cmd.Parameters.AddWithValue("@LayMauPhetDichAmDao", LayMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@SoMauPhetDichAmDao", SoMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@Phodphatase", Phodphatase);
            cmd.Parameters.AddWithValue("@Christmas", Christmas);
            cmd.Parameters.AddWithValue("@LuuMauPhetDichAmDao", LuuMauPhetDichAmDao);
            cmd.Parameters.AddWithValue("@LayMau", LayMau);
            cmd.Parameters.AddWithValue("@QuetNiemMac", QuetNiemMac);
            cmd.Parameters.AddWithValue("@SieuAmBung", SieuAmBung);
            cmd.Parameters.AddWithValue("@DauHieu", DauHieu);
            cmd.Parameters.AddWithValue("@KLKhac", KLKhac);
            cmd.Parameters.AddWithValue("@KhongThucHienPhodphatase", KhongThucHienPhodphatase);
            cmd.Parameters.AddWithValue("@KhongThucHienChristmas", KhongThucHienChristmas);
            cmd.Parameters.AddWithValue("@XetNghiemHIV", XetNghiemHIV);
            cmd.Parameters.AddWithValue("@HoTen1", HoTen1);
            cmd.Parameters.AddWithValue("@DiaDiemGiamDinh", DiaDiemGiamDinh);
            cmd.Parameters.AddWithValue("@HoSoTaiLieu", HoSoTaiLieu);
            cmd.Parameters.AddWithValue("@NoiDungYeuCau", NoiDungYeuCau);
            cmd.Parameters.AddWithValue("@NghienCuuHoSoBenhAn", NghienCuuHoSoBenhAn);
            cmd.Parameters.AddWithValue("@TheTrang", TheTrang);
            cmd.Parameters.AddWithValue("@KhamChuyenKhoa", KhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@KetQuaCanLamSang", KetQuaCanLamSang);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public void delete_ketluantinhduc(string MaKetLuanTinhDuc)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_ketluantinhduc", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTinhDuc", MaKetLuanTinhDuc);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
