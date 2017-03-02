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
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for InHinh.xaml
    /// </summary>
    public partial class InHinh : UserControl
    {
        string _MaHoSo;
        DataView dv;
        ListBox dragSource = null;
        Point startDragPoint, endDragPoint;
        object dataToMove, dataToReplace;
        public InHinh()
        {
            InitializeComponent();
        }
        public InHinh(string MaHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            LoadData();
        }
        private void LoadData()
        {
            TableChupHinh tblCH = new TableChupHinh();
            lstNavigation.ItemsSource = dv = tblCH.get_chuphinh_by_hoso(_MaHoSo);
            lblTongSoHinh.Content = dv.Count;
        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.GetBuffer();
        }

        private void chkChooseImg_Click(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk.IsChecked == true)
            {
                var oldImg = (Image)((StackPanel)chk.Parent).FindName("img");
                var newImg = new Image();

                newImg.Source = oldImg.Source;
                newImg.Tag = oldImg.Tag;

                var border = ExecuteStyle(newImg);

                lstChooseImg.Items.Add(border);

                foreach (Border bdr in lstChooseImg.Items)
                {
                    ((Label)((StackPanel)bdr.Child).Children[1]).Content = "Ảnh " + (lstChooseImg.Items.IndexOf(bdr) + 1);
                }
            }
            else
            {
                foreach (Border bdr in lstChooseImg.Items)
                {
                    if (bdr.Tag.Equals(chk.Tag))
                    {
                        lstChooseImg.Items.Remove(bdr);
                        break;
                    }
                }
                foreach (Border bdr in lstChooseImg.Items)
                {
                    ((Label)((StackPanel)bdr.Child).Children[1]).Content = "Ảnh " + (lstChooseImg.Items.IndexOf(bdr) + 1);
                }
            }
            lblSoHinhDuocChon.Content = lstChooseImg.Items.Count;
            if (lstChooseImg.Items.Count > 0)
                btnSave.IsEnabled = true;
            else
                btnSave.IsEnabled = false;
        }

        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        private void lstChooseImg_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            startDragPoint = e.GetPosition(parent);
            dataToMove = GetDataFromListBox(dragSource, startDragPoint);

            if (dataToMove != null)
            {
                DragDrop.DoDragDrop(parent, dataToMove, DragDropEffects.Move);
            }
        }

        private void lstChooseImg_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            endDragPoint = e.GetPosition(parent);
            dataToReplace = GetDataFromListBox(parent, endDragPoint);

            if (!dataToMove.Equals(dataToReplace))
            {
                int index = parent.Items.IndexOf(dataToMove);
                int index1 = parent.Items.IndexOf(dataToReplace);

                var newImg = new Image();
                newImg.Source = ((Image)((StackPanel)(((Border)dataToMove).Child)).Children[0]).Source;
                newImg.Tag = ((Image)((StackPanel)(((Border)dataToMove).Child)).Children[0]).Tag;

                var border = ExecuteStyle(newImg);

                if (index1 < 0)
                    parent.Items.Add(border);
                else
                {
                    if (index < index1)
                        parent.Items.Insert(index1 + 1, border);
                    else
                        parent.Items.Insert(index1, border);
                }
                parent.SelectedItem = border;

                ((ListBox)sender).Items.Remove(dataToMove);
                foreach (Border bdr in lstChooseImg.Items)
                {
                    ((Label)((StackPanel)bdr.Child).Children[1]).Content = "Ảnh " + (lstChooseImg.Items.IndexOf(bdr) + 1);
                }
            }
        }

        private Border ExecuteStyle(Image img)
        {
            var border = new Border();
            var stackPnl = new StackPanel();
            var lbl = new Label();

            border.Width = 100;
            border.Height = 100;
            border.Margin = new Thickness(2);
            border.Background = Brushes.White;
            border.BorderBrush = Brushes.Silver;
            border.BorderThickness = new Thickness(1);
            border.Tag = img.Tag;
            lbl.HorizontalAlignment = HorizontalAlignment.Center;
            img.Margin = new Thickness(0, 0, 0, 2);
            img.MaxHeight = 70;
            img.Stretch = Stretch.Uniform;

            stackPnl.Children.Add(img);
            stackPnl.Children.Add(lbl);
            border.Child = stackPnl;

            return border;
        }

        private void lstChooseImg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox lst = (ListBox)sender;
            if (GetDataFromListBox(lst, e.GetPosition(lst)) == null)
            {
                lst.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var tblChupHinh = new TableChupHinh();
            tblChupHinh.clear_thutuchonhinh(_MaHoSo);

            for (int i = 0; i < lstChooseImg.Items.Count; i++)
            {
                var border = (Border)lstChooseImg.Items[i];
                tblChupHinh.update_thutuchonhinh(border.Tag.ToString(), (i + 1).ToString());
            }
            MessageBox.Show("Cập nhật thành công.");
        }

        private void lstNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstNavigation.SelectedIndex != -1)
            {
                BorderImgBig.DataContext = dv[lstNavigation.SelectedIndex];
            }
        }
    }
}
