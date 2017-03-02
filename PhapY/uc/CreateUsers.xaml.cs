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

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for CreateUsers.xaml
    /// </summary>
    public partial class CreateUsers : UserControl
    {
        public CreateUsers()
        {
            InitializeComponent();
            string[] roles = Roles.GetAllRoles();
            comboBox1.ItemsSource = roles;
            comboBox1.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btnCreateUsers_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(comboboxNhanVien1.MaNhanVien))
            {
                MembershipUserCollection muc = Membership.FindUsersByName(txtUserName.Text);
                if (muc.Count == 0)
                {
                    Membership.CreateUser(txtUserName.Text, txtPWD.Password);
                    Roles.AddUserToRole(txtUserName.Text, comboBox1.SelectedValue.ToString());
                    TableUsers tblUser = new TableUsers();
                    tblUser.insertUser(txtUserName.Text, comboboxNhanVien1.MaNhanVien);
                    MessageBox.Show("Tạo tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Xin chọn tên đăng nhập khác!");
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên sử dụng tài khoản này.");
            }
        }
    }
}
