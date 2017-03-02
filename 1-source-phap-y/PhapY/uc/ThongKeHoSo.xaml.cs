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
using System.Data;
using PhapY.App_Code;
using System.Windows.Threading;
using ComponentArt.Win.UI.Data;
using PhapY.SubWindows;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for ThongKeHoSo.xaml
    /// </summary>
    public partial class ThongKeHoSo : UserControl
    {
        DataView dv;
        bool datagridViewStatus = false;
        int selectedIndex;
        public ThongKeHoSo()
        {
            InitializeComponent();
            for (int i = 1; i < DateTime.Now.Month; i++)
            {
                ComboBoxItem cbbItem = new ComboBoxItem();
                cbbItem.Content = i + 1;
                cbbChooseMonth.Items.Add(cbbItem);
                if (i + 1 == DateTime.Now.Month)
                {
                    cbbChooseMonth.SelectedIndex = selectedIndex = i;
                }
            }
        }

        private void LoadData(string Month)
        {
            TableHoSo tblReports = new TableHoSo();
            dataGrid1.ItemsSource = dv = tblReports.thongke_ho_so_theo_thang(Month);
            int total = dv.Count;
            tblkTotal.Content = total.ToString();
            dataGrid1.Refresh();
            dataGrid1.CurrentPageIndex = 0;
            if (datagridViewStatus)
            {
                ViewImageList();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
            RefreshData();
        }
        public void RefreshData()
        {
            cbbChooseMonth.SelectedIndex = cbbChooseMonth.Items.Count - 1;
            LoadData(((ComboBoxItem)(cbbChooseMonth.SelectedValue)).Content.ToString());
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                if (dataGrid1.SelectedRow != null)
                {
                    dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
                }
            }
        }
        private void cbbChooseMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.IsInitialized)
            {
                LoadData(((ComboBoxItem)((ComboBox)sender).SelectedValue).Content.ToString());
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData(DateTime.Now.Month.ToString());
        }
        private void btnListView_Click(object sender, RoutedEventArgs e)
        {
            if (datagridViewStatus)
            {
                ViewList();
                datagridViewStatus = false;
            }
            btnListView.Visibility = Visibility.Collapsed;
            btnImgView.Visibility = Visibility.Visible;
        }

        private void btnImgView_Click(object sender, RoutedEventArgs e)
        {
            if (!datagridViewStatus)
            {
                ViewImageList();
                datagridViewStatus = true;
            }
            btnListView.Visibility = Visibility.Visible;
            btnImgView.Visibility = Visibility.Collapsed;
        }
        void ViewList()
        {
            dataGrid1.Columns["HinhDuongSu"].Width = new GridLength(0);
            for (int i = dataGrid1.CurrentPageIndex * dataGrid1.PageSize; i < dataGrid1.CurrentPageIndex * dataGrid1.PageSize + dataGrid1.PageSize; i++)
            {
                var row = dataGrid1.GetRow(i);
                if (row != null)
                {
                    var img = (Image)row.Cells["HinhDuongSu"].FindTemplateChild("imgHinhDuongSu");
                    img.Visibility = Visibility.Collapsed;
                }
            }
            dataGrid1.Refresh();
        }
        void ViewImageList()
        {
            dataGrid1.Columns["HinhDuongSu"].Width = new GridLength(100);
            for (int i = dataGrid1.CurrentPageIndex * dataGrid1.PageSize; i < dataGrid1.CurrentPageIndex * dataGrid1.PageSize + dataGrid1.PageSize; i++)
            {
                var row = dataGrid1.GetRow(i);
                if (row != null)
                {
                    var img = (Image)dataGrid1.GetRow(i).Cells["HinhDuongSu"].FindTemplateChild("imgHinhDuongSu");
                    img.Visibility = Visibility.Visible;
                }
            }
            dataGrid1.Refresh();
        }

        private void dataGrid1_PageIndexChanged(object sender, DataGridPageIndexChangedEventArgs e)
        {
            var dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 1);
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (!datagridViewStatus)
            {
                ViewList();
            }
            else
            {
                ViewImageList();
            }
            ((DispatcherTimer)sender).Stop();
        }

        private void cbbChooseMonth_Loaded(object sender, RoutedEventArgs e)
        {
            var cbbItem = new ComboBoxItem();
            cbbItem.Content = "- Tất cả -";
            ((ComboBox)sender).Items.Insert(0, cbbItem);
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                WindowXemHoSo wAddDS = new WindowXemHoSo(dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string TuNgay = dpTuNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpTuNgay.SelectedDate.Value) : "";
            string DenNgay = dpDenNgay.SelectedDate != null ? string.Format("{0:MM/dd/yyyy}", dpDenNgay.SelectedDate.Value) : "";
            TableHoSo tblReports = new TableHoSo();
            dataGrid1.ItemsSource = dv = tblReports.thongke_ho_so_theo_ngay_thang(TuNgay, DenNgay);
            int total = dv.Count;
            tblkTotal.Content = total.ToString();
            dataGrid1.Refresh();
            dataGrid1.CurrentPageIndex = 0;
            if (datagridViewStatus)
            {
                ViewImageList();
            }
        }
        public void ComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            dataGrid1.Filters.Clear();
            if (((ComponentArt.Win.UI.Input.ComboBox)sender).SelectedItem != null)
            {
                DataGridDataCondition dgdc = new DataGridDataCondition("TinhTrangHoSo", ((ComponentArt.Win.UI.Input.ComboBox)sender).SelectedItem.Content.ToString(), DataGridDataConditionOperand.Contains);
                dataGrid1.FilterBy(dgdc);
            }
        }

        private void btnExcelExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var dt = new DataTable();
                dt.Columns.Add("SoHoSo");
                dt.Columns.Add("QDTCGDSo");
                dt.Columns.Add("KyNgay");
                dt.Columns.Add("CoQuanTrungCau");
                dt.Columns.Add("HoTen");
                dt.Columns.Add("NamSinh");
                dt.Columns.Add("GioiTinh");
                dt.Columns.Add("DiaChi");
                dt.Columns.Add("DienThoai");
                dt.Columns.Add("NgheNghiep");
                dt.Columns.Add("NgayDenLamHoSo");
                dt.Columns.Add("XayRaNgay");
                dt.Columns.Add("Tai");
                dt.Columns.Add("DieuTraVien");
                dt.Columns.Add("DienThoaiDTV");

                foreach (DataRowView drv in dv)
                {
                    var SoHoSo = drv["SoHoSo"];
                    var QDTCGDSo = drv["QDTCGDSo"];
                    var KyNgay = drv["KyNgay"];
                    var CoQuanTrungCau = drv["CoQuanTrungCau"];
                    var HoTen = drv["HoTen"];
                    var NamSinh = drv["NamSinh"];
                    var GioiTinh = string.IsNullOrEmpty(drv["GioiTinh"].ToString()) ? "" : (drv["GioiTinh"].ToString() == "True" ? "Nam" : "Nữ");
                    var DiaChi = drv["DiaChi"];
                    var DienThoai = drv["DienThoai"];
                    var NgheNghiep = drv["NgheNghiep"];
                    var NgayDenLamHoSo = drv["NgayDenLamHoSo"];
                    var XayRaNgay = drv["XayRaNgay"];
                    var Tai = drv["Tai"];
                    var DieuTraVien = drv["DieuTraVien"];
                    var DienThoaiDTV = drv["DienThoaiDTV"];

                    dt.Rows.Add(new object[] { 
                        SoHoSo,
                        QDTCGDSo,
                        KyNgay,
                        CoQuanTrungCau,
                        HoTen,
                        NamSinh,
                        GioiTinh,
                        DiaChi,
                        DienThoai,
                        NgheNghiep,
                        NgayDenLamHoSo,
                        XayRaNgay,
                        Tai,
                        DieuTraVien,
                        DienThoaiDTV
                    });
                }

                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

                dlg.Filter = "Excel 97 - 2003 Workbook (*.xls)|*.xls";
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Export export = new Export("Win");
                    export.ExportDetails(dt, Export.ExportFormat.Excel, dlg.FileName);
                }

                if (MessageBox.Show("Lưu thành công. Mở tập tin?", "Lưu thành công.", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                    System.Diagnostics.Process.Start(dlg.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
