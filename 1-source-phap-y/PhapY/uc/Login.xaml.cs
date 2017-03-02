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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web.Security;
using PhapY.uc;
using PhapY.App_Code;
using PhapY.SubWindows;


namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            bool remember = Properties.Settings.Default.Remember;
            chkRemember.IsChecked = remember;
            if (remember)
            {
                string usn = Properties.Settings.Default.LoginUserName;
                string pwd = Properties.Settings.Default.LoginPassword;
                txtUserName.Text = usn;
                txtPWD.Password = pwd;
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Membership.ValidateUser(txtUserName.Text, txtPWD.Password))
                {
                    var tbl = new TableUsers();
                    Properties.Settings.Default.Remember = chkRemember.IsChecked.Value;
                    Properties.Settings.Default.LoginUserName = txtUserName.Text;
                    Properties.Settings.Default.LoginPassword = txtPWD.Password;
                    Properties.Settings.Default.Save();
                    MainWindow._Container.Children.Clear();
                    MainWindow._UserName = txtUserName.Text;
                    MainWindow._RoleName = Roles.GetRolesForUser(txtUserName.Text)[0];
                    MainWindow._MaNhanVien = tbl.getEmpIDbyUserName(MainWindow._UserName);
                    if (Roles.GetRolesForUser(txtUserName.Text)[0] == Properties.Settings.Default.Role1)
                    {
                        MainWindow._menuCreateUser.IsEnabled = MainWindow._menuTSX.IsEnabled = MainWindow._menuNhanVien.IsEnabled = true;
                    }
                    else
                    {
                        MainWindow._menuCreateUser.IsEnabled = MainWindow._menuTSX.IsEnabled = MainWindow._menuNhanVien.IsEnabled = false;
                    }
                    MainWindow._mainMenu.IsEnabled = true;
                    var dshs = new DanhSachHoSo();
                    MainWindow._Container.Children.Add(dshs);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfiguration_Click(object sender, RoutedEventArgs e)
        {
            var wSC = new SQLServerConfiguration();
            wSC.ShowDialog();
        }
    }
}
