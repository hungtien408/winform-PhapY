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

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for BieuDoThongKeTuThi.xaml
    /// </summary>
    public partial class BieuDoThongKeTuThi : UserControl
    {
        public BieuDoThongKeTuThi()
        {
            InitializeComponent();
            var tblHS = new TableTuThi();
            Chart.DataSource = tblHS.bieu_do_thongke_tuthi_theo_thang();
        }
    }
}
