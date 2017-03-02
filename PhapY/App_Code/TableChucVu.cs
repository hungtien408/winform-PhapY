using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableChucVu
    {
        string connectionString = Common.ConnectionString;
        public DataView get_chucvu()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_chucvu", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public string insert_chucvu(string TenChucVu, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_chucvu", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenChucVu", TenChucVu);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public string update_chucvu(string MaChucVu, string TenChucVu, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_chucvu", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);
            cmd.Parameters.AddWithValue("@TenChucVu ", TenChucVu);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public void delete_chucvu(string MaChucVu)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_chucvu", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChucVu", MaChucVu);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
