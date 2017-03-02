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
using PhapY.App_Code;
using System.Data;
using System.Diagnostics;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        DataTable dt = new DataTable();
        object misValue = System.Reflection.Missing.Value;
        public Window5()
        {
            InitializeComponent();

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TableNhanVien tblNV = new TableNhanVien();
            dt = tblNV.get_nhanvien().Table;

            System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            
            dlg.Filter = "Excel 97 - 2003 Workbook (*.xls)|*.xls";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Export export = new Export("Win");
                export.ExportDetails(dt, Export.ExportFormat.Excel, dlg.FileName);
            }

            

            //ExportUtil.Export("UserList_" + string.Format("{0:ddMMyyyy}", DateTime.Now) + ".xls", dt);



        }
    }
}
