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
using System.Windows.Threading;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ComboboxNhanVien : UserControl
    {
        private string _MaNhanVien, _TenNhanVien, _Text,_SoThe;
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "SelectionFinalized", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ComboboxNhanVien));
        DispatcherTimer t;
        public ComboboxNhanVien()
        {
            InitializeComponent();
            TableNhanVien tblNV = new TableNhanVien();
            MyComboBox.ItemsSource = tblNV.get_nhanvien();
        }
        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }
            set
            {
                _MaNhanVien = value;
            }
        }
        public string TenNhanVien
        {
            get
            {
                return _TenNhanVien;
            }
            set
            {
                _TenNhanVien = value;
            }
        }
        public string SoThe
        {
            get
            {
                return _SoThe;
            }
            set
            {
                _SoThe = value;
            }
        }
        private childItem FindVisualChild<childItem>(DependencyObject obj)
        where childItem : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                {
                    return (childItem)child;
                }
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }
        public event RoutedEventHandler SelectionFinalized
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        // This method raises the Tap event
        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(ComboboxNhanVien.TapEvent);
            RaiseEvent(newEventArgs);
        }
        private void MyComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            ComponentArt.Win.UI.Input.ComboBoxItem selectedItem = MyComboBox.SelectedItem;
            if (selectedItem != null)
            {
                ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(selectedItem);
                _MaNhanVien = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditMaNhanVien", myContentPresenter)).Text;
                _TenNhanVien = ((TextBlock)selectedItem.ContentTemplate.FindName("ItemText", myContentPresenter)).Text;
            }
            RaiseTapEvent();
        }
        public void SetSelectedText(string Text)
        {
            _Text = Text;
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 1);
            t.Tick += new EventHandler(dispatcherTimer_Tick);
            t.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MyComboBox.SelectItem(_Text);
            ComponentArt.Win.UI.Input.ComboBoxItem selectedItem = MyComboBox.SelectedItem;
            if (selectedItem != null)
            {
                ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(selectedItem);
                _MaNhanVien = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditMaNhanVien", myContentPresenter)).Text;
                _TenNhanVien = ((TextBlock)selectedItem.ContentTemplate.FindName("ItemText", myContentPresenter)).Text;
                _SoThe = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditSoThe", myContentPresenter)).Text;
            }
            t.Stop();
        }

    }
}
