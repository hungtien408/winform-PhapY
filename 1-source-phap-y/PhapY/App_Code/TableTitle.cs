using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableTitle
    {
        string connectionString = Common.ConnectionString;
        public DataView get_title()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_title", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public string insert_title(string Title, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_title", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public string update_title(string MaTitle, string Title, string DienGiai)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_title", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTitle", MaTitle);
            cmd.Parameters.AddWithValue("@Title ", Title);
            cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
            scon.Open();
            string row_index = cmd.ExecuteScalar().ToString();
            scon.Close();
            return row_index;
        }

        public void delete_title(string MaTitle)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete_title", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTitle", MaTitle);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
