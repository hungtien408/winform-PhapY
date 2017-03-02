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
using PhapY.uc;

namespace PhapY.TemplateControl
{
    /// <summary>
    /// Interaction logic for TemplateNhanvien.xaml
    /// </summary>
    public partial class TemplateNhanvien : UserControl
    {
        public TemplateNhanvien()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            DanhSachNhanVien dsNV = new DanhSachNhanVien();
            Container.Children.Add(dsNV);
        }

        private void btnChucVu_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            DanhSachChucVu dsCV = new DanhSachChucVu();
            Container.Children.Add(dsCV);
        }

        private void btnTitle_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            DanhSachTitle dsTitle = new DanhSachTitle();
            Container.Children.Add(dsTitle);
        }
    }
}
