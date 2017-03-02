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
using PhapY.uc;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowThemTuThi.xaml
    /// </summary>
    public partial class WindowThemTuThi : Window
    {
        public WindowThemTuThi()
        {
            InitializeComponent();
        }

        public WindowThemTuThi(DanhSachHoSoTuThi dshstt, string MaHoSo)
        {
            InitializeComponent();
            var ThemTT = new ThemTuThi(dshstt, MaHoSo);
            Container.Children.Add(ThemTT);
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role3)
            {
                ThemTT.btnAdd.Visibility = ThemTT.btnChonBS.Visibility = ThemTT.btnDel.Visibility = ThemTT.btnEdit.Visibility = Visibility.Collapsed;
            }
        }
    }
}
