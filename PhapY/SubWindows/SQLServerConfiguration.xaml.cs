using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for SQLServerConfiguration.xaml
    /// </summary>
    public partial class SQLServerConfiguration : Window
    {
        #region Common Method
        bool IsSerVerChanged = false;
        public SQLServerConfiguration()
        {
            InitializeComponent();
        }

        void GetServer()
        {
            var dvServerName = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources().DefaultView;
            var lstServerName = new List<string>();

            foreach (DataRowView drv in dvServerName)
            {
                var strServerName = drv["ServerName"].ToString();
                var strInstanceName = drv["InstanceName"].ToString();
                lstServerName.Add(strServerName + (string.IsNullOrEmpty(strInstanceName) ? "" : "/" + strInstanceName));
            }

            cbxServerName.ItemsSource = lstServerName;
        }

        void GetDatabase(string ServerName)
        {
            try
            {
                var strConnectionString = "Data Source=" + ServerName + ";Integrated Security = sspi";

                var dt = new DataTable();
                var cn = new SqlConnection(strConnectionString);
                var cmd = new SqlCommand("SELECT [name] FROM sys.sysdatabases WHERE HAS_DBACCESS(name) = 1", cn);
                cmd.CommandType = CommandType.Text;
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                var lstDatabaseName = new List<string>();

                foreach (DataRowView drv in dt.DefaultView)
                {
                    var strDatabaseName = drv["name"].ToString();
                    lstDatabaseName.Add(strDatabaseName);
                }

                cbxDatabaseName.ItemsSource = lstDatabaseName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbxDatabaseName.ItemsSource = null;
            }
        }

        void GetDatabase(string ServerName, string Username, string Password)
        {
            try
            {
                var strConnectionString = "Data Source=" + ServerName +
                ";User ID=" + Username +
                ";Password=" + Password;

                var dt = new DataTable();
                var cn = new SqlConnection(strConnectionString);
                var cmd = new SqlCommand("SELECT [name] FROM sys.sysdatabases WHERE HAS_DBACCESS(name) = 1", cn);
                cmd.CommandType = CommandType.Text;
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                var lstDatabaseName = new List<string>();

                foreach (DataRowView drv in dt.DefaultView)
                {
                    var strDatabaseName = drv["name"].ToString();
                    lstDatabaseName.Add(strDatabaseName);
                }

                cbxDatabaseName.ItemsSource = lstDatabaseName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cbxDatabaseName.ItemsSource = null;
            }
        }
        #endregion

        #region Event
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string strServerName = cbxServerName.FilterTextBox.Text.Trim();
            string strDatabaseName = cbxDatabaseName.FilterTextBox.Text.Trim();
            string strUserName = txtUserName.Text.Trim();
            string strPassword = txtPassword.Password;

            Properties.Settings.Default.ServerName = strServerName;
            Properties.Settings.Default.DatabaseName = strDatabaseName;
            Properties.Settings.Default.UserName = strUserName;
            Properties.Settings.Default.Password = strPassword;
            Properties.Settings.Default.Save();

            string connectionStr = "Data Source=" + strServerName + ";Initial Catalog=" + strDatabaseName + ";User ID=" + strUserName + ";Password=" + strPassword;

            Application.Current.Properties["ConnectionString"] = connectionStr;

            MessageBox.Show("Lưu thành công.");
            this.Close();
        }

        private void btnTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var strConnectionString = "";
            string strServerName = cbxServerName.FilterTextBox.Text.Trim();
            string strUserName = txtUserName.Text.Trim();
            string strPassword = txtPassword.Password;

            if (chkWindowAccount.IsChecked.Value)
                strConnectionString = "Data Source=" + strServerName + ";Integrated Security = sspi";
            else
                strConnectionString = "Data Source=" + strServerName + ";User ID=" + strUserName + ";Password=" + strPassword;

            using (var con = new SqlConnection(strConnectionString))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Kết nối thành công.");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Kết nối thất bại.");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void cbxServerName_DefaultButtonClick(object sender, RoutedEventArgs e)
        {
            if (cbxServerName.ItemsSource == null)
            {
                GetServer();
            }
        }

        private void btnRefreshServerName_Click(object sender, RoutedEventArgs e)
        {
            GetServer();
        }

        private void cbxDatabaseName_DefaultButtonClick(object sender, RoutedEventArgs e)
        {
            if (IsSerVerChanged)
            {
                IsSerVerChanged = false;

                var strServerName = cbxServerName.FilterTextBox.Text.Trim();
                var strUserName = txtUserName.Text.Trim();
                var strPassword = txtPassword.Password;

                if (chkWindowAccount.IsChecked.Value)
                {
                    GetDatabase(strServerName);
                }
                else
                {
                    GetDatabase(strServerName, strUserName, strPassword);
                }
            }
        }

        private void btnRefreshDatabaseName_Click(object sender, RoutedEventArgs e)
        {
            IsSerVerChanged = false;

            var strServerName = cbxServerName.FilterTextBox.Text.Trim();
            var strUserName = txtUserName.Text.Trim();
            var strPassword = txtPassword.Password;

            if (chkWindowAccount.IsChecked.Value)
            {
                GetDatabase(strServerName);
            }
            else
            {
                GetDatabase(strServerName, strUserName, strPassword);
            }
        }

        private void cbxServerName_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            IsSerVerChanged = true;
        }

        private void chkWindowAccount_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                IsSerVerChanged = true;
                txtUserName.IsEnabled = false;
                txtPassword.IsEnabled = false;
                txtUserName.Text = "sa";
                txtPassword.Password = "123456";
            }
            catch { }
        }

        private void chkSQLAccount_Checked(object sender, RoutedEventArgs e)
        {
            IsSerVerChanged = true;
            txtUserName.IsEnabled = true;
            txtPassword.IsEnabled = true;
        }

        private void btnClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
