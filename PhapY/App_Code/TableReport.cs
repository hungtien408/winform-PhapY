using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableReport
    {
        string connectionString = Common.ConnectionString;
        DBNull dbNull = DBNull.Value;
        public DataView rpt_get_tuthi(string MaHoSoFrom, string MaHoSoTo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("rpt_get_tuthi", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSoFrom", MaHoSoFrom == string.Empty ? (object)dbNull : MaHoSoFrom);
            cmd.Parameters.AddWithValue("@MaHoSoTo", MaHoSoTo == string.Empty ? (object)dbNull : MaHoSoTo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView rpt_get_thuongtat(string MaHoSoFrom, string MaHoSoTo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("rpt_get_thuongtat", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSoFrom", MaHoSoFrom == string.Empty ? (object)dbNull : MaHoSoFrom);
            cmd.Parameters.AddWithValue("@MaHoSoTo", MaHoSoTo == string.Empty ? (object)dbNull : MaHoSoTo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        public DataView rpt_get_khamtrinh(string MaHoSoFrom, string MaHoSoTo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("rpt_get_khamtrinh", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSoFrom", MaHoSoFrom == string.Empty ? (object)dbNull : MaHoSoFrom);
            cmd.Parameters.AddWithValue("@MaHoSoTo", MaHoSoTo == string.Empty ? (object)dbNull : MaHoSoTo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
    }
}
