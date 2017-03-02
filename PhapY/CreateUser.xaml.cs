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
using System.Web.Security;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
            getData();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Membership.CreateUser(textBox1.Text, passwordBox1.Password);
            getData();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Roles.CreateRole(textBox2.Text);
            getData();
        }
        private void getData()
        {
            string[] roles = Roles.GetAllRoles();
            comboBox1.ItemsSource = roles;
            MembershipUserCollection muc = Membership.GetAllUsers();
            comboBox2.ItemsSource = muc;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Roles.AddUserToRole(comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Membership.DeleteUser(comboBox2.SelectedValue.ToString(),true);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Roles.DeleteRole(comboBox1.SelectedValue.ToString());
        }
    }
}
