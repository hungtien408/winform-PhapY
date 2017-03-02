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
using ComponentArt.Win.UI.Data;
using System.Windows.Threading;
using System.Globalization;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using PhapY.SubWindows;
using PhapY.App_Code;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for DanhSachHoSo.xaml
    /// </summary>

    public partial class DanhSachHoSo : UserControl
    {
        public DataView dv;
        bool datagridViewStatus = false;
        public static DataGrid dg;
        public DanhSachHoSo()
        {
            InitializeComponent();
            dg = dataGrid1;//Brushes.Azure
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role2)
            {
                btnInsert.Visibility = btnEdit.Visibility = btnDelete.Visibility = btnQuickEdit.Visibility = Visibility.Collapsed;
                foreach (DataGridColumn d in dataGrid1.Columns)
                {
                    if (d.Header != null)
                    {
                        if (d.Header.ToString() == "Edit")
                        {
                            d.Visibility = Visibility.Collapsed;
                            break;
                        }
                    }
                }
            }
        }
        private void getData()
        {
            dataGrid1.ClearFilters();
            TableHoSo tblDS = new TableHoSo();
            dataGrid1.ItemsSource = dv = tblDS.get_hoso();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            getData();
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);

            if (oCell != null)
            {
                dataGrid1.SelectRow(oCell.OwningRow);
                WindowThemHoSo wAddDS = new WindowThemHoSo(this, dv[oCell.OwningRow.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show(" Xoá dòng này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);

                if (oCell != null)
                {
                    dataGrid1.DeleteRow(oCell.OwningRow);
                    string MaHoSo = oCell.OwningRow.Cells["MaHoSo"].Text;
                    TableHoSo tblHS = new TableHoSo();
                    tblHS.delete_hoso(MaHoSo);
                }
            }
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                if (dataGrid1.SelectedRow != null)
                {
                    dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
                }
            }
            WindowThemHoSo wAddDS = new WindowThemHoSo(this);
            wAddDS.ShowDialog();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
            RefreshData();
        }
        public void RefreshData()
        {
            getData();
            dataGrid1.Refresh();
            dataGrid1.CurrentPageIndex = 0;
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                if (dataGrid1.SelectedRow != null)
                {
                    dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
                }
            }
            //if (datagridViewStatus)
            //{
            //    ViewImageList();
            //}
        }
        private void dataGrid1_RowDoubleClicked(object sender, DataGridRowEventArgs e)
        {
            //MessageBox.Show(e.Row.Cells[0].Text);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                WindowThemHoSo wAddDS = new WindowThemHoSo(this, dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnChupHinh_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                string HoTen = dgr.Cells["HoTen"].Text;
                string DiaChi = dgr.Cells["DiaChi"].Text;
                string DienThoai = dgr.Cells["DienThoai"].Text;
                string NamSinh = dgr.Cells["NamSinh"].Text;
                WindowChupHinh wCH = new WindowChupHinh(MaHoSo, HoTen, DiaChi, DienThoai, NamSinh);
                wCH.ShowDialog();
            }
        }

        //private void btnListView_Click(object sender, RoutedEventArgs e)
        //{
        //    if (datagridViewStatus)
        //    {
        //        ViewList();
        //        datagridViewStatus = false;
        //    }
        //    btnListView.Visibility = Visibility.Collapsed;
        //    btnImgView.Visibility = Visibility.Visible;
        //}

        //private void btnImgView_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!datagridViewStatus)
        //    {
        //        ViewImageList();
        //        datagridViewStatus = true;
        //    }
        //    btnListView.Visibility = Visibility.Visible;
        //    btnImgView.Visibility = Visibility.Collapsed;
        //}
        //void ViewList()
        //{
        //    dataGrid1.Columns["HinhDuongSu"].Width = new GridLength(0);
        //    for (int i = dataGrid1.CurrentPageIndex * dataGrid1.PageSize; i < dataGrid1.CurrentPageIndex * dataGrid1.PageSize + dataGrid1.PageSize; i++)
        //    {
        //        var row = dataGrid1.GetRow(i);
        //        if (row != null)
        //        {
        //            var img = (Image)row.Cells["HinhDuongSu"].FindTemplateChild("imgHinhDuongSu");
        //            img.Visibility = Visibility.Collapsed;
        //        }
        //    }
        //    dataGrid1.Refresh();
        //}
        //void ViewImageList()
        //{
        //    dataGrid1.Columns["HinhDuongSu"].Width = new GridLength(100);
        //    for (int i = dataGrid1.CurrentPageIndex * dataGrid1.PageSize; i < dataGrid1.CurrentPageIndex * dataGrid1.PageSize + dataGrid1.PageSize; i++)
        //    {
        //        var row = dataGrid1.GetRow(i);
        //        if (row != null)
        //        {
        //            var img = (Image)dataGrid1.GetRow(i).Cells["HinhDuongSu"].FindTemplateChild("imgHinhDuongSu");
        //            img.Visibility = Visibility.Visible;
        //        }
        //    }
        //    dataGrid1.Refresh();
        //}

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                if (MessageBox.Show("Chắc chắn xoá dòng này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
                {
                    TableHoSo tblHS = new TableHoSo();
                    tblHS.delete_hoso(dgr.Cells["MaHoSo"].Text);
                    dataGrid1.DeleteRow(dgr);
                }
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
        }

        private void btnInHinh_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                string HoTen = dgr.Cells["HoTen"].Text;
                string DiaChi = dgr.Cells["DiaChi"].Text;
                string DienThoai = dgr.Cells["DienThoai"].Text;
                string NamSinh = dgr.Cells["NamSinh"].Text;
                WindowInHinh wIH = new WindowInHinh(MaHoSo, HoTen, DiaChi, DienThoai, NamSinh);
                wIH.ShowDialog();
            }
        }

        private void btnKLGiamDinhThuongTich_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var wAddDS = new WindowKetLuanGiamDinhThuongTich(MaHoSo, dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        //private void dataGrid1_PageIndexChanged(object sender, DataGridPageIndexChangedEventArgs e)
        //{
        //    var dt = new DispatcherTimer();
        //    dt.Interval = new TimeSpan(0, 0, 0, 1);
        //    dt.Tick += new EventHandler(dt_Tick);
        //    dt.Start();
        //}

        //void dt_Tick(object sender, EventArgs e)
        //{
        //    if (!datagridViewStatus)
        //    {
        //        ViewList();
        //    }
        //    else
        //    {
        //        ViewImageList();
        //    }
        //    ((DispatcherTimer)sender).Stop();
        //}

        private void btnKLGiamDinhTinhDuc_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var wAddDS = new WindowKetLuanGiamDinhTinhDuc(MaHoSo, dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnInBienNhan_Click(object sender, RoutedEventArgs e)
        {
            
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var ibn = new InBienNhan(dv[dgr.Index]);
                ibn.ShowDialog();
            }
        }

        private void btnInBanGiamDinhPhapYThuongTat_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var ibGDPY = new WindowInBanGiamDinhThuongTat(MaHoSo, dv[dgr.Index]);
                ibGDPY.ShowDialog();
            }
        }

        private void btnKLGiamDinhTuThi_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var wAddDS = new WindowKetLuanGiamDinhTuThi(MaHoSo, dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnInBanGiamDinhPhapYTinhDuc_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var ibGDPY = new WindowInBanGiamDinhTinhDuc(MaHoSo, dv[dgr.Index]);
                ibGDPY.ShowDialog();
            }
        }

        private void btnInBanGiamDinhTuThi_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                var ibGDPY = new WindowInBanGiamDinhTuThi(MaHoSo);
                ibGDPY.ShowDialog();
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

        private void btnLock_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);

            if (oCell != null)
            {
                if (MessageBox.Show("Khoá hồ sơ này?", "Khoá hồ sơ", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
                {
                    TableHoSo tblHS = new TableHoSo();
                    tblHS.khoahoso(oCell.OwningRow.Cells["MaHoSo"].Text);
                    var btnUnlock = (Button)oCell.FindTemplateChild("btnUnlock");
                    btnUnlock.Visibility = Visibility.Visible;
                    ((Button)sender).Visibility = Visibility.Collapsed;
                    string editColumnName = "";
                    foreach (DataGridColumn d in dataGrid1.Columns)
                    {
                        if (d.Header != null)
                        {
                            if (d.Header.ToString() == "Edit")
                            {
                                editColumnName = d.ColumnName;
                                break;
                            }
                        }
                    }
                    oCell.OwningRow.Cells["TinhTrangHoSo"].Value = true;
                    ((StackPanel)oCell.OwningRow.Cells[editColumnName].FindTemplateChild("pnlEdit")).Visibility = Visibility.Collapsed;
                    App.ThemHanhDong(MainWindow._MaNhanVien, "Khóa hồ sơ thuơng tích/khám trinh.", oCell.OwningRow.Cells["MaHoSo"].Text, oCell.OwningRow.Cells["SoHoSo"].Text, string.Format("{0:MM/dd/yyyy hh:mm tt}", DateTime.Now), oCell.OwningRow.Cells["QDTCGDSo"].Text);
                }
            }
            dataGrid1.SelectRow(oCell.OwningRow);
        }

        private void btnUnLock_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow._RoleName != Properties.Settings.Default.Role1)
            {
                ((Button)sender).IsEnabled = false;
            }
        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);

            if (oCell != null)
            {
                if (MessageBox.Show("Hồ sơ đang khoá, mở hồ sơ?", "Mở hồ sơ", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
                {
                    TableHoSo tblHS = new TableHoSo();
                    tblHS.mokhoakhoahoso(oCell.OwningRow.Cells["MaHoSo"].Text);
                    var btnLock = (Button)oCell.FindTemplateChild("btnLock");
                    btnLock.Visibility = Visibility.Visible;
                    ((Button)sender).Visibility = Visibility.Collapsed;
                    string editColumnName = "";
                    foreach (DataGridColumn d in dataGrid1.Columns)
                    {
                        if (d.Header != null)
                        {
                            if (d.Header.ToString() == "Edit")
                            {
                                editColumnName = d.ColumnName;
                                break;
                            }
                        }
                    }
                    oCell.OwningRow.Cells["TinhTrangHoSo"].Value = false;
                    ((StackPanel)oCell.OwningRow.Cells[editColumnName].FindTemplateChild("pnlEdit")).Visibility = Visibility.Visible;
                }
            }
            dataGrid1.SelectRow(oCell.OwningRow);
        }

        private void dataGrid1_SelectionChanged(object sender, DataGridSelectionChangedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string TinhTrangHoSo = dgr.Cells["TinhTrangHoSo"].Text;
                string MaLoaiHSTTKT = dgr.Cells["MaLoaiHSTTKT"].Text;
                if (bool.Parse(TinhTrangHoSo))
                {
                    btnEdit.IsEnabled = false;
                    btnDelete.IsEnabled = false;
                    btnQuickEdit.IsEnabled = false;
                }
                else
                {
                    btnEdit.IsEnabled = true;
                    btnDelete.IsEnabled = true;
                    btnQuickEdit.IsEnabled = true;
                }
                if (MaLoaiHSTTKT == "1")
                {
                    btnKLGiamDinhThuongTich.IsEnabled = btnInBanGiamDinhPhapYThuongTat.IsEnabled = true;
                    btnKLGiamDinhTinhDuc.IsEnabled = btnInBanGiamDinhPhapYTinhDuc.IsEnabled = false;
                }
                else
                {
                    btnKLGiamDinhThuongTich.IsEnabled = btnInBanGiamDinhPhapYThuongTat.IsEnabled = false;
                    btnKLGiamDinhTinhDuc.IsEnabled = btnInBanGiamDinhPhapYTinhDuc.IsEnabled = true;
                }
            }
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);

            if (oCell != null)
            {
                dataGrid1.SelectRow(oCell.OwningRow);
                var wAddDS = new WindowXemHoSo(dv[oCell.OwningRow.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                var wAddDS = new WindowXemHoSo(dv[dgr.Index]);
                wAddDS.ShowDialog();
            }
        }

        private void btnQuickEdit_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow oRow = dataGrid1.SelectedRow;

            if (oRow != null)
            {
                oRow.Edit();
            }
        }
        private void dataGrid1_RowEdited(object sender, DataGridRowEditedEventArgs e)
        {
            string MaHoSo = e.Row.Cells["MaHoSo"].Text;
            string DangOPhong = e.Row.Cells["DangOPhong"].Text;
            var tblHS = new TableHoSo();
            tblHS.update_hosodangophong(MaHoSo, DangOPhong);
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.EditComplete();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.EditCancel();
        }

        private void btnLock_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow._RoleName != Properties.Settings.Default.Role1 && MainWindow._RoleName != Properties.Settings.Default.Role2)
            {
                ((Button)sender).IsEnabled = false;
            }
        }

        private void btnPhuLucThuongTich_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                string MaHoSo = dgr.Cells["MaHoSo"].Text;
                string SoHoSo = dgr.Cells["SoHoSo"].Text;
                var wPLTT = new PhuLucThuongTich(MaHoSo, SoHoSo);
                wPLTT.ShowDialog();
            }
        }

        private void dataGrid1_FilterChanged(object sender, DataGridFilterChangedEventArgs e)
        {
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                if (dataGrid1.SelectedRow != null)
                {
                    dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
                }
            }
        }

        private void cbbFilterLoaiHS_Loaded(object sender, RoutedEventArgs e)
        {
            var tbl = new TableHoSo();
            DataView dv = tbl.get_LoaiHoSoTTKT();
            DataTable dt = dv.ToTable();
            DataRow dr = dt.NewRow();
            dr["TenLoaiHSTTKT"] = "- Tất cả -";
            dr["MaLoaiHSTTKT"] = -1;
            dt.Rows.InsertAt(dr, 0);
            ((ComboBox)sender).ItemsSource = dt.DefaultView;
            ((ComboBox)sender).SelectedValue = dt.DefaultView[0]["MaLoaiHSTTKT"];
        }

        private void cbbFilterLoaiHS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid1.Filters.Clear();
            if (((ComboBox)sender).SelectedValue != null)
            {
                string s = ((ComboBox)sender).SelectedValue.ToString();
                if (s == "-1")
                {
                    s = "";
                }
                DataGridDataCondition dgdc = new DataGridDataCondition("MaLoaiHSTTKT", s, DataGridDataConditionOperand.Contains);
                dataGrid1.FilterBy(dgdc);
            }
        }

        private void dataGrid1_BeforeSortingChanged(object sender, DataGridSortingChangedCancelEventArgs e)
        {
            if (e.Sortings[0].Column.ColumnName == "SoHoSo")
            {
                var sortstate = dataGrid1.Columns["SoHoSoSub"].SortState;
                SortDirection sd = sortstate == null ? SortDirection.Ascending : (sortstate == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending);
                DataGridSorting ds = new DataGridSorting(dataGrid1.Columns["SoHoSoSub"], sd);
                e.Sortings[0] = ds;
            }
        }

    }
}
