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


namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowChonBacSi.xaml
    /// </summary>
    public partial class WindowChonBacSi : Window
    {
        public static string _MaNhanVien, _TenNhanVien,_ChucVu, _Text, _SoThe;
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "SelectionFinalized", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowChonBacSi));
        DispatcherTimer t;
        public WindowChonBacSi()
        {
            InitializeComponent();
            TableNhanVien tblNV = new TableNhanVien();
            //MyComboBox.ItemsSource = tblNV.get_bschinh();
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
        public string ChucVu
        {
            get
            {
                return _ChucVu;
            }
            set
            {
                _ChucVu = value;
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
            RoutedEventArgs newEventArgs = new RoutedEventArgs(WindowChonBacSi.TapEvent);
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
                _SoThe = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditSoThe", myContentPresenter)).Text;
                _ChucVu = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditChucVu", myContentPresenter)).Text;
            }
            RaiseTapEvent();
            this.Close();
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
