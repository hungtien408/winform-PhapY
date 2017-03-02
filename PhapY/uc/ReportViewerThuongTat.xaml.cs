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
using Microsoft.Reporting.WinForms;
using PhapY.App_Code;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for ReportViewer.xaml
    /// </summary>
    public partial class ReportViewerThuongTat : UserControl
    {
        public ReportViewerThuongTat()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            viewerInstance.LocalReport.DataSources.Clear();
            var oReport = new TableReport();
            var dataSource = oReport.rpt_get_thuongtat(txtMaHoSoTu.Text, txtMaHoSoDen.Text);
            ReportDataSource reportDataSource = new ReportDataSource("dsThuongTat", dataSource);

            viewerInstance.LocalReport.ReportPath = "Reports/ThuongTat.rdlc";
            viewerInstance.LocalReport.DataSources.Add(reportDataSource);
            viewerInstance.RefreshReport();
        }
        private void viewerInstance_ZoomChange(object sender, ZoomChangeEventArgs e)
        {

        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        } 
    }
}
