using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TablePhuLucTuThi
    {
        string connectionString = Common.ConnectionString;
        public DataView get_phuluctuthi(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_phuluctuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public void update_phuluctuthi(
            string MaHoSo,
	        string BanGiamDinhYPhapTuThi,
	        string BanKetLuanTuThi,
	        string QuyetDinhTrungCauGiamDinh,
	        string GiayBaoTu,
	        string GiayUopXac,
	        string CongHam,
	        string HoChieu,
	        string SoDoPhacHoaNguoiBiNan,
	        string XetNghiemNongDoRuou,
	        string XetNghiemMorPhin,
	        string XetNghiemSinhHoa,
	        string XetNghiemHIV,
	        string PhieuXetNghiemGPB,
	        string BienBanXemXetDauVetCoThe,
	        string BanKetLuanGiamDinhPhapYVeHoaPhap,
	        string Khac,
	        string NoiDungKhac,
	        string TongCong
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_phuluctuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@BanGiamDinhYPhapTuThi", BanGiamDinhYPhapTuThi);
            cmd.Parameters.AddWithValue("@BanKetLuanTuThi", BanKetLuanTuThi);
            cmd.Parameters.AddWithValue("@QuyetDinhTrungCauGiamDinh", QuyetDinhTrungCauGiamDinh);
            cmd.Parameters.AddWithValue("@GiayBaoTu", GiayBaoTu);
            cmd.Parameters.AddWithValue("@GiayUopXac", GiayUopXac);
            cmd.Parameters.AddWithValue("@CongHam", CongHam);
            cmd.Parameters.AddWithValue("@HoChieu", HoChieu);
            cmd.Parameters.AddWithValue("@SoDoPhacHoaNguoiBiNan", SoDoPhacHoaNguoiBiNan);
            cmd.Parameters.AddWithValue("@XetNghiemNongDoRuou", XetNghiemNongDoRuou);
            cmd.Parameters.AddWithValue("@XetNghiemMorPhin", XetNghiemMorPhin);
            cmd.Parameters.AddWithValue("@XetNghiemSinhHoa", XetNghiemSinhHoa);
            cmd.Parameters.AddWithValue("@XetNghiemHIV", XetNghiemHIV);
            cmd.Parameters.AddWithValue("@PhieuXetNghiemGPB", PhieuXetNghiemGPB);
            cmd.Parameters.AddWithValue("@BienBanXemXetDauVetCoThe", BienBanXemXetDauVetCoThe);
            cmd.Parameters.AddWithValue("@BanKetLuanGiamDinhPhapYVeHoaPhap", BanKetLuanGiamDinhPhapYVeHoaPhap);
            cmd.Parameters.AddWithValue("@Khac", Khac);
            cmd.Parameters.AddWithValue("@NoiDungKhac", NoiDungKhac);
            cmd.Parameters.AddWithValue("@TongCong", TongCong);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

       
    }
}
