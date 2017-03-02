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
using PhapY.App_Code;
using System.Windows.Threading;
using System.Globalization;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for DanhSachNhanVien.xaml
    /// </summary>

    public partial class DanhSachNhanVien : UserControl
    {
        DataView dv;
        string MaNhanVien, MaNhanVienMoi, HoTen, NamSinh, MaChucVu, MaTitle, SoThe, DienThoai, DiaChi, Email, DienThoaiLienLac, BsChinh;
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void getData()
        {
            TableNhanVien tblNV = new TableNhanVien();
            dataGrid1.ItemsSource = dv = tblNV.get_nhanvien();
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
                oCell.OwningRow.Edit();
                dataGrid1.SelectRow(oCell.OwningRow);
                DisableRows(oCell.OwningRow);
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
                    string MaNhanVien = oCell.OwningRow.Cells["MaNhanVien"].Text;
                    TableNhanVien tblNV = new TableNhanVien();
                    tblNV.delete_nhanvien(MaNhanVien);
                }
            }
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell(sender as FrameworkElement);
            DataGridRow oRow = oCell.OwningRow;
            string MaNhanVienCu = oRow.Cells["MaNhanVienCu"].Text;
            string MaNhanVien = ((TextBox)oRow.Cells["MaNhanVien"].FindTemplateChild("txtMaNhanVien")).Text;
            string HoTen = ((TextBox)oRow.Cells["HoTen"].FindTemplateChild("txtHoTen")).Text;
            string MaChucVu = ((ComboboxChucVu)oRow.Cells["TenChucVu"].FindTemplateChild("cbbCV")).SelectedValue;
            string MaTitle = ((ComboboxTitle)oRow.Cells["Title"].FindTemplateChild("cbbTitle")).SelectedValue;
            string NamSinh = ((Microsoft.Windows.Controls.DatePicker)oRow.Cells["NamSinh"].FindTemplateChild("dpNamSinh")).SelectedDate.ToString();
            string error = "";
            if (string.IsNullOrEmpty(MaNhanVien))
            {
                error += "- Nhập mã nhân viên. \n";
            }
            else
            {
                TableNhanVien tblNV = new TableNhanVien();
                bool exist = tblNV.get_duplicate_manhanvien(MaNhanVienCu, MaNhanVien);
                if (exist)
                {
                    error += "- Mã nhân viên đã tồn tại, nhập mã nhân viên khác. \n";
                }
            }
            if (string.IsNullOrEmpty(HoTen))
            {
                error += "- Nhập họ tên. \n";
            }
            if (string.IsNullOrEmpty(MaChucVu))
            {
                error += "- Chọn chức vụ. \n";
            }
            if (string.IsNullOrEmpty(MaTitle))
            {
                error += "- Chọn Title. \n";
            }
            if (string.IsNullOrEmpty(NamSinh))
            {
                error += "- Chọn năm sinh. \n";
            }
            if (error != "")
            {
                MessageBox.Show(error);
            }
            else
            {
                dataGrid1.EditComplete();
                EnableRows();
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.EditCancel();
            EnableRows();
        }

        private void dataGrid1_RowEdited(object sender, DataGridRowEditedEventArgs e)
        {
            MaNhanVien = e.Row.Cells["MaNhanVienCu"].Text;
            MaNhanVienMoi = e.Row.Cells["MaNhanVien"].Text;
            HoTen = e.Row.Cells["HoTen"].Text;
            NamSinh = e.Row.Cells["NamSinh"].Text;
            MaChucVu = e.Row.Cells["MaChucVu"].Text;
            MaTitle = e.Row.Cells["MaTitle"].Text;
            SoThe = e.Row.Cells["SoThe"].Text;
            DienThoai = e.Row.Cells["DienThoai"].Text;
            DiaChi = e.Row.Cells["DiaChi"].Text;
            Email = e.Row.Cells["Email"].Text;
            DienThoaiLienLac = e.Row.Cells["DienThoaiLienLac"].Text;
            BsChinh = e.Row.Cells["BsChinh"].Text;

            try
            {
                DateTime dateNamSinh = DateTime.Parse(NamSinh, System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"));
                NamSinh = string.Format("{0:MM/dd/yyyy}", dateNamSinh);

                TableNhanVien tblNV = new TableNhanVien();
                tblNV.update_nhanvien(MaNhanVien, MaNhanVienMoi, HoTen, NamSinh, MaChucVu, MaTitle, SoThe, DienThoai, DiaChi, Email, "", BsChinh);
            }
            catch (SqlException) { }

            //e.Row.Cells["MaNhanVienCu"].Value = MaNhanVienMoi;

            dataGrid1.SortBy(dataGrid1.Columns["HoTen"], SortDirection.Ascending);
            //get edited row index after dataGrid1 sortted
            dv.Sort = "MaNhanVien";
            int rowFindedIndex = dv.Find(MaNhanVien);
            dv[rowFindedIndex]["MaNhanVien"] = MaNhanVienMoi;
            dv[rowFindedIndex]["HoTen"] = HoTen;
            dv.Sort = "HoTen asc";
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["MaNhanVien"].ToString() == MaNhanVienMoi)
                {
                    dataGrid1.CurrentPageIndex = Int32.Parse((i / dataGrid1.PageSize).ToString());
                    break;
                }
            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow oRow = dataGrid1.GetEditingRow();
            if (oRow != null)
            {
                oRow.EditCancel();
            }
            dataGrid1.AddRow();
            App.sv.ScrollToEnd();
            dataGrid1.GetEditingRow().Focus();
            dataGrid1.SelectRow(dataGrid1.GetEditingRow());
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
            DataGridRow oRow = dataGrid1.GetEditingRow();
            if (oRow != null)
            {
                oRow.EditCancel();
            }
            getData();
            dataGrid1.CurrentPageIndex = 0;
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                if (dataGrid1.SelectedRow != null)
                {
                    dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
                }
            }
        }

        private void dataGrid1_RowDoubleClicked(object sender, DataGridRowEventArgs e)
        {
            //MessageBox.Show(e.Row.Cells[0].Text);
        }
        
        private void dataGrid1_RowAdded(object sender, DataGridRowAddedEventArgs e)
        {
            MaNhanVien = e.Row.Cells["MaNhanVien"].Text;
            HoTen = e.Row.Cells["HoTen"].Text;
            NamSinh = e.Row.Cells["NamSinh"].Text;
            MaChucVu = e.Row.Cells["MaChucVu"].Text;
            MaTitle = e.Row.Cells["MaTitle"].Text;
            SoThe = e.Row.Cells["SoThe"].Text;
            DienThoai = e.Row.Cells["DienThoai"].Text;
            DiaChi = e.Row.Cells["DiaChi"].Text;
            Email = e.Row.Cells["Email"].Text;
            DienThoaiLienLac = e.Row.Cells["DienThoaiLienLac"].Text;
            BsChinh = e.Row.Cells["BsChinh"].Text;

            TableNhanVien tblNV = new TableNhanVien();
            try
            {
                DateTime dateNamSinh = DateTime.Parse(NamSinh, System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"));
                NamSinh = string.Format("{0:MM/dd/yyyy}", dateNamSinh);
                tblNV.insert_nhanvien(MaNhanVien, HoTen, NamSinh, MaChucVu, MaTitle, SoThe, DienThoai, DiaChi, Email, "", BsChinh);
            }
            catch (Exception) { }
            getData();
            dataGrid1.SortBy(dataGrid1.Columns["HoTen"], SortDirection.Ascending);
            //get edited row index after dataGrid1 sortted
            dv.Sort = "MaNhanVien";
            int rowFindedIndex = dv.Find(MaNhanVien);
            dv[rowFindedIndex]["HoTen"] = HoTen;
            dv.Sort = "HoTen asc";
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["MaNhanVien"].ToString() == MaNhanVien)
                {
                    dataGrid1.CurrentPageIndex = Int32.Parse((i / dataGrid1.PageSize).ToString());
                    dataGrid1.SelectRow(i);
                    break;
                }
            }
        }

        private void ComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            //dataGrid1.Filters.Clear();
            //DataGridDataCondition dgdc = new DataGridDataCondition("NhaSanXuat", ((ComponentArt.Win.UI.Input.ComboBox)sender).FilterTextBox.Text, DataGridDataConditionOperand.Contains);
            //dataGrid1.FilterBy(dgdc);
        }

        private void cbbCV_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            string MaChucVu = oCell.OwningRow.Cells["MaChucVu"].Text;
            ((ComboboxChucVu)sender).SelectedValue = MaChucVu;
        }

        private void cbbCV_SelectionFinalized(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            oCell.Value = ((ComboboxChucVu)sender).SelectedText;
            oCell.OwningRow.Cells["MaChucVu"].Value = ((ComboboxChucVu)sender).SelectedValue;
        }

        private void cbbTitle_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            string MaTitle = oCell.OwningRow.Cells["MaTitle"].Text;
            ((ComboboxTitle)sender).SelectedValue = MaTitle;
        }

        private void cbbTitle_SelectionFinalized(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            oCell.Value = ((ComboboxTitle)sender).SelectedText;
            oCell.OwningRow.Cells["MaTitle"].Value = ((ComboboxTitle)sender).SelectedValue;
        }

        private void DatePicker_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            if (oCell.Value != null)
            {
                ((Microsoft.Windows.Controls.DatePicker)sender).SelectedDate = DateTime.Parse(oCell.Value.ToString());
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((DependencyObject)sender);
            DateTime dt = ((Microsoft.Windows.Controls.DatePicker)sender).SelectedDate.Value;
            oCell.Value = dt.ToShortDateString();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            if (oCell.Value != null)
            {
                ((TextBox)sender).Text = oCell.Value.ToString();
            }
            if (oCell.OwningColumn.ColumnName == "MaNhanVien")
            {
                oCell.OwningRow.Cells["MaNhanVienCu"].Value = oCell.Value;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            oCell.Value = ((TextBox)sender).Text;
        }
        
        private void dataGrid1_CellEditEnd(object sender, DataGridCellEventArgs e)
        {
            EnableRows();
        }

        private void dataGrid1_CellEditBegin(object sender, DataGridCellEventArgs e)
        {
            DisableRows(e.Cell.OwningRow);
        }

        private void dataGrid1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                EnableRows();
            }
        }
        void EnableRows()
        {
            var Rows = from n in dataGrid1.LoadedRows select n;
            foreach (var Row in Rows)
            {
                if (Row.IsEnabled == false)
                {
                    Row.IsEnabled = true;
                    Row.Foreground = Brushes.Black;
                }
            }
        }
        void DisableRows(DataGridRow dgr)
        {
            var currentRow = dgr;
            var disableRows = from n in dataGrid1.LoadedRows where n != currentRow select n;
            foreach (var disableRow in disableRows)
            {
                disableRow.IsEnabled = false;
                disableRow.Foreground = new SolidColorBrush(Color.FromRgb(175, 175, 175));
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                dgr.Edit();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = dataGrid1.SelectedRow;
            if (dgr != null)
            {
                if (MessageBox.Show(" Xoá dòng này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    string MaNhanVien = dgr.Cells["MaNhanVien"].Text;
                    TableNhanVien tblNV = new TableNhanVien();
                    tblNV.delete_nhanvien(MaNhanVien);
                    dataGrid1.DeleteRow(dgr);
                }
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            DataGridCell oCell = dataGrid1.GetOwningCell((FrameworkElement)sender);
            oCell.OwningRow.Cells["BsChinh"].Value = ((CheckBox)sender).IsChecked.Value;
        }
    }
}
