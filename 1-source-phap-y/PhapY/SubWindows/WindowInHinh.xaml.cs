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
using Microsoft.Win32;
using PhapY.App_Code;
using System.IO;
using System.Data;
using PhapY.uc;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowInHinh.xaml
    /// </summary>
    public partial class WindowInHinh : Window
    {
        string _MaHoSo, _HoTen, _NamSinh, _DiaChi, _DienThoai;
        public WindowInHinh()
        {
            InitializeComponent();
        }
        public WindowInHinh(string MaHoSo, string HoTen, string DiaChi, string DienThoai, string NamSinh)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            lblTenDS.Content = _HoTen = HoTen;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            lblNamSinh.Content = _NamSinh = NamSinh;
            if (MainWindow._RoleName != Properties.Settings.Default.Role1)
            {
                btnChonHinh.Visibility = Visibility.Collapsed;
                var ih = new XemHinhChup(_MaHoSo);
                Container.Children.Clear();
                Container.Children.Add(ih);
            }
            else
            {
                var ih = new InHinh(_MaHoSo);
                Container.Children.Add(ih);
            }
        }

        private void btnChonHinh_Click(object sender, RoutedEventArgs e)
        {
            var ih = new InHinh(_MaHoSo);
            Container.Children.Clear();
            Container.Children.Add(ih);
        }

        private void btnXemHinhDuocChon_Click(object sender, RoutedEventArgs e)
        {
            var ih = new XemHinhChup(_MaHoSo);
            Container.Children.Clear();
            Container.Children.Add(ih);
        }
        
    }
}

