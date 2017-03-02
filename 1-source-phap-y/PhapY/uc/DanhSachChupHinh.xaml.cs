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

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for DanhSachChupHinh.xaml
    /// </summary>
    public partial class DanhSachChupHinh : UserControl
    {
        public DanhSachChupHinh()
        {
            InitializeComponent();
        }
        private void getData()
        {
            //TableChupHinh tblNV = new TableChupHinh();
            //dataGrid1.ItemsSource = tblNV.get_nhanvien();
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
                    string MaChupHinh = oCell.OwningRow.Cells["MaChupHinh"].Text;
                    //TableChupHinh tblNV = new TableChupHinh();
                    //tblNV.delete_nhanvien(MaChupHinh);
                }
            }
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.EditComplete();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.EditCancel();
        }

        private void dataGrid1_RowEdited(object sender, DataGridRowEditedEventArgs e)
        {
            string MaChupHinh = e.Row.Cells["MaChupHinh"].Text;
            string TenChupHinh = e.Row.Cells["TenChupHinh"].Text;
            string DiaChi = e.Row.Cells["DiaChi"].Text;
            string DienThoai = e.Row.Cells["DienThoai"].Text;
            //TableChupHinh tblNV = new TableChupHinh();
            //tblNV.update_nhanvien(MaChupHinh, TenChupHinh, DiaChi, DienThoai);
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
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            getData();
            dataGrid1.CurrentPageIndex = 0;
            int selectedIndexs = (dataGrid1.SelectedIndices).Count;

            for (int i = 0; i < selectedIndexs; i++)
            {
                dataGrid1.UnSelectRow(dataGrid1.SelectedRow);
            }
        }

        private void dataGrid1_RowDoubleClicked(object sender, DataGridRowEventArgs e)
        {
            //MessageBox.Show(e.Row.Cells[0].Text);
        }

        private void dataGrid1_RowAdded(object sender, DataGridRowAddedEventArgs e)
        {
            string TenChupHinh = e.Row.Cells["TenChupHinh"].Text;
            string DiaChi = e.Row.Cells["DiaChi"].Text;
            string DienThoai = e.Row.Cells["DienThoai"].Text;
            //TableChupHinh tblNV = new TableChupHinh();
            //tblNV.insert_nhanvien(TenChupHinh, DiaChi, DienThoai);
            getData();
            dataGrid1.CurrentPageIndex = 0;
            dataGrid1.SelectRow(0);
        }

        private void ComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            //dataGrid1.Filters.Clear();
            //DataGridDataCondition dgdc = new DataGridDataCondition("NhaSanXuat", ((ComponentArt.Win.UI.Input.ComboBox)sender).FilterTextBox.Text, DataGridDataConditionOperand.Contains);
            //dataGrid1.FilterBy(dgdc);
        }

        private void cbbCV_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cbbCV_SelectionFinalized(object sender, RoutedEventArgs e)
        {

        }

        private void cbbTitle_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cbbTitle_SelectionFinalized(object sender, RoutedEventArgs e)
        {

        }
    }
}
