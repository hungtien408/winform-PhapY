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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (txtPWD.Password == "")
            {
                error += "- Chưa nhập mật khẩu cũ! \n";
            }
            if (txtNewPWD.Password == "")
            {
                error += "- Chưa nhập mật khẩu mới! \n";
            }
            if (txtConfirmPWD.Password == "")
            {
                error += "- Chưa nhập xác nhận mật khẩu mới! \n";
            }
            if (txtNewPWD.Password != txtConfirmPWD.Password)
            {
                error += "- Xác nhận mật khẩu sai! \n";
            }
            if (error == "")
            {
                if (txtConfirmPWD.Password == txtNewPWD.Password)
                {
                    if (Membership.ValidateUser(MainWindow._UserName, txtPWD.Password))
                    {
                        Membership.GetUser(MainWindow._UserName).ChangePassword(txtPWD.Password, txtNewPWD.Password);
                        MessageBox.Show("Đổi password thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.");
                    }
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
