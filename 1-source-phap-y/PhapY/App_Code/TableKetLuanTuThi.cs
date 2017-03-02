using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PhapY.App_Code
{
    public class TableKetLuanTuThi
    {
        string connectionString = Common.ConnectionString;
        public DataView get_ketluantuthi()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluantuthi_by_id(string MaKetLuanTuThi)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantuthi_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTuThi", MaKetLuanTuThi);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_ketluantuthi_by_hoso(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ketluantuthi_by_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public int insert_ketluantuthi(
                string MaHoSo,
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
		        string NguyenNhanChet,
		        string PhuMo1,
		        string PhuMo2,
		        string GiamDinhVien1,
		        string GiamDinhVien2
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_ketluantuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
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
            cmd.Parameters.AddWithValue("@NguyenNhanChet", NguyenNhanChet);
            cmd.Parameters.AddWithValue("@PhuMo1", PhuMo1);
            cmd.Parameters.AddWithValue("@PhuMo2", PhuMo2);
            cmd.Parameters.AddWithValue("@GiamDinhVien1", GiamDinhVien1);
            cmd.Parameters.AddWithValue("@GiamDinhVien2", GiamDinhVien2);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public int update_ketluantuthi(
                string MaKetLuanTuThi,
                string MaHoSo,
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
                string NguyenNhanChet,
                string PhuMo1,
                string PhuMo2,
                string GiamDinhVien1,
                string GiamDinhVien2
           )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_ketluantuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTuThi", MaKetLuanTuThi);
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@NguoiGiamDinh", NguoiGiamDinh);
            cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
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
            cmd.Parameters.AddWithValue("@NguyenNhanChet", NguyenNhanChet);
            cmd.Parameters.AddWithValue("@PhuMo1", PhuMo1);
            cmd.Parameters.AddWithValue("@PhuMo2", PhuMo2);
            cmd.Parameters.AddWithValue("@GiamDinhVien1", GiamDinhVien1);
            cmd.Parameters.AddWithValue("@GiamDinhVien2", GiamDinhVien2);

            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public void delete_ketluantuthi(string MaKetLuanTuThi)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_ketluantuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKetLuanTuThi", MaKetLuanTuThi);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
