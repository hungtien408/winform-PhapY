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
    /// Interaction logic for WindowXemBanGiamDinhTuThi.xaml
    /// </summary>
    public partial class WindowXemBanGiamDinhTuThi : Window
    {
        public WindowXemBanGiamDinhTuThi(string MahoSo)
        {
            InitializeComponent();
            var themTuThi1 = new XemTuThi(MahoSo);
            Container.Children.Add(themTuThi1);
        }
    }
}
