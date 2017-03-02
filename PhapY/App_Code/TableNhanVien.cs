using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableNhanVien
    {
        string connectionString = Common.ConnectionString;
        public DataView get_nhanvien()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_nhanvien", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView get_bschinh()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_bschinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public DataView get_nhanvien_by_id(string MaNhanVien)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_nhanvien_by_id", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public bool get_duplicate_manhanvien(string MaNhanVien,string MaNhanVienMoi)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_duplicate_manhanvien", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@MaNhanVienMoi", MaNhanVienMoi);
            scon.Open();
            bool exists = bool.Parse(cmd.ExecuteScalar().ToString());
            scon.Close();
            return exists;
        }
        public string insert_nhanvien(string MaNhanVien, string HoTen, string NamSinh, string MaChucVu, string MaTitle, string SoThe, string DienThoai, string DiaChi, string Email, string DienThoaiLienLac, string BsChinh)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_nhanvien", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);
            cmd.Parameters.AddWithValue("@MaTitle", MaTitle);
            cmd.Parameters.AddWithValue("@SoThe", SoThe);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DienThoaiLienLac", DienThoaiLienLac);
            cmd.Parameters.AddWithValue("@BsChinh", BsChinh);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public string update_nhanvien(string MaNhanVien, string MaNhanVienMoi, string HoTen, string NamSinh, string MaChucVu, string MaTitle, string SoThe, string DienThoai, string DiaChi, string Email, string DienThoaiLienLac, string BsChinh)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_nhanvien", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@MaNhanVienMoi", MaNhanVienMoi);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@NamSinh", NamSinh);
            cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);
            cmd.Parameters.AddWithValue("@MaTitle", MaTitle);
            cmd.Parameters.AddWithValue("@SoThe", SoThe);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DienThoaiLienLac", DienThoaiLienLac);
            cmd.Parameters.AddWithValue("@BsChinh", BsChinh);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public void delete_nhanvien(string MaNhanVien)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_nhanvien", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
