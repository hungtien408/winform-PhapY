using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PhapY.App_Code
{
    public class TableHoSo
    {
        string connectionString = Common.ConnectionString;
        SqlDateTime sqlnull = SqlDateTime.Null;
        #region
        public string insert_hoso(
                string SoHoSo,
                string QDTCGDSo,
                string CoQuanTrungCau,
                string KyNgay,
                string HoTen,
                byte[] HinhDuongSu,
                string QuocTich,
                string NgayDenLamHoSo,
                string TaiKham,
                string NamSinh,
                string GioiTinh,
                string DiaChi,
                string TamTru,
                string XayRaNgay,
                string Tai,
                string TrinhDoVanHoa,
                string DanToc,
                string TonGiao,
                string NgheNghiep,
                string DienThoai,
                string DieuTraVien,
                string DienThoaiDTV,
                string GiayQDTCGD,
                string GiayCNTT,
                string YChung,
                string GiayRaVien,
                string ToaThuoc,
                string SoKhamBenh,
                string GiayXacNhanNamVien,
                string BenhAnTomTat,
                string Khac,
                string TT,
                string SK,
                string YC,
                string DT,
                string QHS,
                string TD,
                string NguoiNhanHoSo,
                string TongSoKhamChuyenKhoa,
                string MaLoaiHSTTKT
            )
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoHoSo", SoHoSo);
            cmd.Parameters.AddWithValue("@QDTCGDSo", QDTCGDSo);
            cmd.Parameters.AddWithValue("@CoQuanTrungCau", CoQuanTrungCau);
            cmd.Parameters.AddWithValue("@KyNgay", !string.IsNullOrEmpty(KyNgay) ? (object)KyNgay : sqlnull);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@HinhDuongSu", HinhDuongSu);
            cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
            cmd.Parameters.AddWithValue("@NgayDenLamHoSo", NgayDenLamHoSo);
            cmd.Parameters.AddWithValue("@TaiKham", TaiKham);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@TamTru", TamTru);
            cmd.Parameters.AddWithValue("@XayRaNgay", !string.IsNullOrEmpty(XayRaNgay) ? (object)XayRaNgay : sqlnull);
            cmd.Parameters.AddWithValue("@Tai", Tai);
            cmd.Parameters.AddWithValue("@TrinhDoVanHoa", TrinhDoVanHoa);
            cmd.Parameters.AddWithValue("@DanToc", DanToc);
            cmd.Parameters.AddWithValue("@TonGiao", TonGiao);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@GiayQDTCGD", GiayQDTCGD);
            cmd.Parameters.AddWithValue("@GiayCNTT", GiayCNTT);
            cmd.Parameters.AddWithValue("@YChung", YChung);
            cmd.Parameters.AddWithValue("@GiayRaVien", GiayRaVien);
            cmd.Parameters.AddWithValue("@ToaThuoc", ToaThuoc);
            cmd.Parameters.AddWithValue("@SoKhamBenh", SoKhamBenh);
            cmd.Parameters.AddWithValue("@GiayXacNhanNamVien", GiayXacNhanNamVien);
            cmd.Parameters.AddWithValue("@BenhAnTomTat", BenhAnTomTat);
            cmd.Parameters.AddWithValue("@Khac", Khac);
            cmd.Parameters.AddWithValue("@TT", TT);
            cmd.Parameters.AddWithValue("@SK", SK);
            cmd.Parameters.AddWithValue("@YC", YC);
            cmd.Parameters.AddWithValue("@DT", DT);
            cmd.Parameters.AddWithValue("@QHS", QHS);
            cmd.Parameters.AddWithValue("@TD", TD);
            cmd.Parameters.AddWithValue("@NguoiNhanHoSo", NguoiNhanHoSo);
            cmd.Parameters.AddWithValue("@TongSoKhamChuyenKhoa", TongSoKhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@MaLoaiHSTTKT", MaLoaiHSTTKT);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }
        #endregion
        #region
        public string update_hoso(
                string MaHoSo,
                string SoHoSo,
                string QDTCGDSo,
                string CoQuanTrungCau,
                string KyNgay,
                string HoTen,
                byte[] HinhDuongSu,
                string QuocTich,
                string NgayDenLamHoSo,
                string TaiKham,
                string NamSinh,
                string GioiTinh,
                string DiaChi,
                string TamTru,
                string XayRaNgay,
                string Tai,
                string TrinhDoVanHoa,
                string DanToc,
                string TonGiao,
                string NgheNghiep,
                string DienThoai,
                string DieuTraVien,
                string DienThoaiDTV,
                string GiayQDTCGD,
                string GiayCNTT,
                string YChung,
                string GiayRaVien,
                string ToaThuoc,
                string SoKhamBenh,
                string GiayXacNhanNamVien,
                string BenhAnTomTat,
                string Khac,
                string TT,
                string SK,
                string YC,
                string DT,
                string QHS,
                string TD,
                string NguoiNhanHoSo,
                string TongSoKhamChuyenKhoa,
                string MaLoaiHSTTKT
            )
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@SoHoSo", SoHoSo);
            cmd.Parameters.AddWithValue("@QDTCGDSo", QDTCGDSo);
            cmd.Parameters.AddWithValue("@CoQuanTrungCau", CoQuanTrungCau);
            cmd.Parameters.AddWithValue("@KyNgay", !string.IsNullOrEmpty(KyNgay) ? (object)KyNgay : sqlnull);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@HinhDuongSu", HinhDuongSu);
            cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
            cmd.Parameters.AddWithValue("@NgayDenLamHoSo", NgayDenLamHoSo);
            cmd.Parameters.AddWithValue("@TaiKham", TaiKham);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@TamTru", TamTru);
            cmd.Parameters.AddWithValue("@XayRaNgay", !string.IsNullOrEmpty(XayRaNgay) ? (object)XayRaNgay : sqlnull);
            cmd.Parameters.AddWithValue("@Tai", Tai);
            cmd.Parameters.AddWithValue("@TrinhDoVanHoa", TrinhDoVanHoa);
            cmd.Parameters.AddWithValue("@DanToc", DanToc);
            cmd.Parameters.AddWithValue("@TonGiao", TonGiao);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@DieuTraVien", DieuTraVien);
            cmd.Parameters.AddWithValue("@DienThoaiDTV", DienThoaiDTV);
            cmd.Parameters.AddWithValue("@GiayQDTCGD", GiayQDTCGD);
            cmd.Parameters.AddWithValue("@GiayCNTT", GiayCNTT);
            cmd.Parameters.AddWithValue("@YChung", YChung);
            cmd.Parameters.AddWithValue("@GiayRaVien", GiayRaVien);
            cmd.Parameters.AddWithValue("@ToaThuoc", ToaThuoc);
            cmd.Parameters.AddWithValue("@SoKhamBenh", SoKhamBenh);
            cmd.Parameters.AddWithValue("@GiayXacNhanNamVien", GiayXacNhanNamVien);
            cmd.Parameters.AddWithValue("@BenhAnTomTat", BenhAnTomTat);
            cmd.Parameters.AddWithValue("@Khac", Khac);
            cmd.Parameters.AddWithValue("@TT", TT);
            cmd.Parameters.AddWithValue("@SK", SK);
            cmd.Parameters.AddWithValue("@YC", YC);
            cmd.Parameters.AddWithValue("@DT", DT);
            cmd.Parameters.AddWithValue("@QHS", QHS);
            cmd.Parameters.AddWithValue("@TD", TD);
            cmd.Parameters.AddWithValue("@NguoiNhanHoSo", NguoiNhanHoSo);
            cmd.Parameters.AddWithValue("@TongSoKhamChuyenKhoa", TongSoKhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@MaLoaiHSTTKT", MaLoaiHSTTKT);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }
        #endregion
        public void delete_hoso(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

        public void update_hosodangophong(string MaHoSo,string DangOPhong)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_hosodangophong", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@DangOPhong", DangOPhong);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public void khoahoso(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("khoahoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public void mokhoakhoahoso(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("mokhoakhoahoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public DataView get_hoso()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView get_LoaiHoSoTTKT()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_LoaiHoSoTTKT", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView get_hoso_by_id(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_hoso_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView thongke_ho_so_theo_thang(string Month)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("thongke_ho_so_theo_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Month", Month);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView bieu_do_thongke_ho_so_theo_thang()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("bieu_do_thongke_ho_so_theo_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView thongke_ho_so_theo_ngay_thang(string startdate, string enddate)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("thongke_ho_so_theo_ngay_thang", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@enddate", enddate);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
    }
}
