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
    /// Interaction logic for BieuDoThongKeHoSo.xaml
    /// </summary>
    public partial class BieuDoThongKeHoSo : UserControl
    {
        public BieuDoThongKeHoSo()
        {
            InitializeComponent();
            TableHoSo tblHS = new TableHoSo();
            Chart.DataSource = tblHS.bieu_do_thongke_ho_so_theo_thang();
        }
    }
}
