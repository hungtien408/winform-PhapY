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
using PhapY.App_Code;
using System.Data;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for testXPS.xaml
    /// </summary>
    public partial class testXPS : UserControl
    {
        DataView dv;
        public testXPS()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
            dv = tblKLTT.get_ketluanthuongtich_by_hoso("6");
            Container.DataContext = dv[0];
        }
    }
}
