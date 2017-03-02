using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using PhapY.App_Code;

namespace PhapY
{
    public class TableUsers
    {
        string connectionString = Common.ConnectionString;
        public int insertUser(string UserName, string EmpID)
        {
            try
            {
                SqlConnection scon = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("insertUser", scon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@EmpID", EmpID);
                scon.Open();
                int success = cmd.ExecuteNonQuery();
                scon.Close();
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }


        public string getEmpIDbyUserName(string UserName)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("getEmpIDbyUserName", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            scon.Open();
            string EmpID = cmd.ExecuteScalar().ToString();
            scon.Close();
            return EmpID;
        }
    }
}
