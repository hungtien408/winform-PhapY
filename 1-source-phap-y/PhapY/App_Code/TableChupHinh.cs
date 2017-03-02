using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableChupHinh
    {
        string connectionString = Common.ConnectionString;
        public DataView get_chuphinh()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_chuphinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView get_chuphinh_by_hoso(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_chuphinh_by_hoso", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView get_thutuchonhinh(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_thutuchonhinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public int insert_chuphinh(string MaHoSo, byte[] Hinh, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_chuphinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@Hinh", Hinh);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public int update_chuphinh(string HinhID, string MaHoSo, byte[] Hinh, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_chuphinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HinhID", HinhID);
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@Hinh", Hinh);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

        public void delete_chuphinh(string HinhID)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_chuphinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HinhID", HinhID);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

        public void clear_thutuchonhinh(string MaHoSo)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("clear_thutuchonhinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

        public void update_thutuchonhinh(string HinhID, string ThuTuChon)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_thutuchonhinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HinhID", HinhID);
            cmd.Parameters.AddWithValue("@ThuTuChon", ThuTuChon);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
