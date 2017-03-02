using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TableNgayGioSuaXoa
    {
        string connectionString = Common.ConnectionString;
        public DataView get_ngaygiosuaxoa()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_ngaygiosuaxoa", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
        
        public int insert_ngaygiosuaxoa(
                string EmpID,
	            string HanhDong,
	            string MaHoSo,
	            string SoHoSo,
	            string NgaySua,
	            string QDTCGDSo
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_ngaygiosuaxoa", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", EmpID);
            cmd.Parameters.AddWithValue("@HanhDong", HanhDong);
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@SoHoSo", SoHoSo);
            cmd.Parameters.AddWithValue("@NgaySua", NgaySua);
            cmd.Parameters.AddWithValue("@QDTCGDSo", QDTCGDSo);
            scon.Open();
            int success = cmd.ExecuteNonQuery();
            scon.Close();
            return success;
        }

    }
}
