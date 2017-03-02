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
using System.Data;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for DanhSachChucVu.xaml
    /// </summary>
    public partial class DanhSachChucVu : UserControl
    {
        DataView dv;
        public DanhSachChucVu()
        {
            InitializeComponent();
        }
        private void getData()
        {
            TableChucVu tblCV = new TableChucVu();
            dataGrid1.ItemsSource = dv =tblCV.get_chucvu();
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
                    string MaChucVu = oCell.OwningRow.Cells["MaChucVu"].Text;
                    TableChucVu tblCV = new TableChucVu();
                    tblCV.delete_chucvu(MaChucVu);
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
            string MaChucVu = e.Row.Cells["MaChucVu"].Text;
            string TenChucVu = e.Row.Cells["TenChucVu"].Text;
            string DienGiai = e.Row.Cells["DienGiai"].Text;
            TableChucVu tblCV = new TableChucVu();
            tblCV.update_chucvu(MaChucVu, TenChucVu, DienGiai);

            dataGrid1.SortBy(dataGrid1.Columns["TenChucVu"], SortDirection.Ascending);
            //get edited row index after dataGrid1 sortted
            dv.Sort = "MaChucVu";
            int rowFindedIndex = dv.Find(MaChucVu);
            dv[rowFindedIndex]["TenChucVu"] = TenChucVu;
            dv.Sort = "TenChucVu asc";
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["MaChucVu"].ToString() == MaChucVu)
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
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            App.ResetFilter();
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
            string TenChucVu = e.Row.Cells["TenChucVu"].Text;
            string DienGiai = e.Row.Cells["DienGiai"].Text;
            TableChucVu tblCV = new TableChucVu();
            string row_index = tblCV.insert_chucvu(TenChucVu, DienGiai);
            getData();
            dataGrid1.CurrentPageIndex = Int32.Parse((Int32.Parse(row_index) / dataGrid1.PageSize).ToString());
            dataGrid1.SelectRow(Int32.Parse(row_index));
        }

        private void ComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            //dataGrid1.Filters.Clear();
            //DataGridDataCondition dgdc = new DataGridDataCondition("NhaSanXuat", ((ComponentArt.Win.UI.Input.ComboBox)sender).FilterTextBox.Text, DataGridDataConditionOperand.Contains);
            //dataGrid1.FilterBy(dgdc);
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
                    string MaChucVu = dgr.Cells["MaChucVu"].Text;
                    TableChucVu tblCV = new TableChucVu();
                    tblCV.delete_chucvu(MaChucVu);
                    dataGrid1.DeleteRow(dgr);
                }
            }
        }
    }
}
