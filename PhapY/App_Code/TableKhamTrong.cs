using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PhapY.App_Code
{
    public class TableKhamTrong
    {
        string connectionString = Common.ConnectionString;
        public DataView get_khamtrong(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_khamtrong", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public void update_khamtrong(
            string MaHoSo,
            string Dau,
            string Co,
            string Nguc,
            string Bung,
            string Tay,
            string Chan
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_khamtrong", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@Dau", Dau);
            cmd.Parameters.AddWithValue("@Co", Co);
            cmd.Parameters.AddWithValue("@Nguc", Nguc);
            cmd.Parameters.AddWithValue("@Bung", Bung);
            cmd.Parameters.AddWithValue("@Tay", Tay);
            cmd.Parameters.AddWithValue("@Chan", Chan);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
