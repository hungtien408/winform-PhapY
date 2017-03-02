using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableKhamNgoai
    {
        string connectionString = Common.ConnectionString;
        public DataView get_khamngoai(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_khamngoai", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public void update_khamngoai(
            string MaHoSo,
            string MoTaTuTheTuThi,
            string DacDiemQuanAoMauSac,
            string TinhTrangDauMat,
            string Co,
            string Nguc,
            string Bung,
            string Lung,
            string Mong,
            string CoQuanSinhDuc,
            string HauMon,
            string Tay,
            string Chan
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_khamngoai", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@MoTaTuTheTuThi", MoTaTuTheTuThi);
            cmd.Parameters.AddWithValue("@DacDiemQuanAoMauSac", DacDiemQuanAoMauSac);
            cmd.Parameters.AddWithValue("@TinhTrangDauMat", TinhTrangDauMat);
            cmd.Parameters.AddWithValue("@Co", Co);
            cmd.Parameters.AddWithValue("@Nguc", Nguc);
            cmd.Parameters.AddWithValue("@Bung", Bung);
            cmd.Parameters.AddWithValue("@Lung", Lung);
            cmd.Parameters.AddWithValue("@Mong", Mong);
            cmd.Parameters.AddWithValue("@CoQuanSinhDuc", CoQuanSinhDuc);
            cmd.Parameters.AddWithValue("@HauMon", HauMon);
            cmd.Parameters.AddWithValue("@Tay", Tay);
            cmd.Parameters.AddWithValue("@Chan", Chan);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}
