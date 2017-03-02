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
    /// Interaction logic for DanhSachTitle.xaml
    /// </summary>
    public partial class DanhSachTitle : UserControl
    {
        DataView dv;
        public DanhSachTitle()
        {
            InitializeComponent();
        }
        private void getData()
        {
            TableTitle tblTitle = new TableTitle();
            dataGrid1.ItemsSource = dv= tblTitle.get_title();
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
                    string MaTitle = oCell.OwningRow.Cells["MaTitle"].Text;
                    TableTitle tblTitle = new TableTitle();
                    tblTitle.delete_title(MaTitle);
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
            string MaTitle = e.Row.Cells["MaTitle"].Text;
            string Title = e.Row.Cells["Title"].Text;
            string DienGiai = e.Row.Cells["DienGiai"].Text;
            TableTitle tblTitle = new TableTitle();
            tblTitle.update_title(MaTitle, Title, DienGiai);

            dataGrid1.SortBy(dataGrid1.Columns["Title"], SortDirection.Ascending);
            //get edited row index after dataGrid1 sortted
            dv.Sort = "MaTitle";
            int rowFindedIndex = dv.Find(MaTitle);
            dv[rowFindedIndex]["Title"] = Title;
            dv.Sort = "Title asc";
            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["MaTitle"].ToString() == MaTitle)
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
            string Title = e.Row.Cells["Title"].Text;
            string DienGiai = e.Row.Cells["DienGiai"].Text;
            TableTitle tblTitle = new TableTitle();
            string row_index = tblTitle.insert_title(Title, DienGiai);
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
                    string MaTitle = dgr.Cells["MaTitle"].Text;
                    TableTitle tblTT = new TableTitle();
                    tblTT.delete_title(MaTitle);
                    dataGrid1.DeleteRow(dgr);
                }
            }
        }
    }
}
