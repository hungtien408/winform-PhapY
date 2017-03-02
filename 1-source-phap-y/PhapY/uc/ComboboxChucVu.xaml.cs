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
using System.Data;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ComboboxChucVu : UserControl
    {
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "SelectionFinalized", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ComboboxChucVu));
        public event RoutedEventHandler SelectionFinalized
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }
        // This method raises the Tap event
        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(ComboboxChucVu.TapEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty CreateItemCommandProperty =
        DependencyProperty.Register(
            "SelectedValue",
            typeof(ICommand),
            typeof(ComboboxChucVu)
        );
        public static readonly DependencyProperty CreateItemCommandProperty1 =
        DependencyProperty.Register(
            "SelectedText",
            typeof(ICommand),
            typeof(ComboboxChucVu)
        );

        private string _Value, _Text;
        DispatcherTimer t;
        public ComboboxChucVu()
        {
            InitializeComponent();
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 1);
            TableChucVu tblCV = new TableChucVu();
            MyComboBox.ItemsSource = tblCV.get_chucvu();
        }
        public string SelectedValue
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                t.Tick += new EventHandler(dispatcherTimer_Tick1);
                t.Start();
            }
        }
        public string SelectedText
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                t.Tick += new EventHandler(dispatcherTimer_Tick);
                t.Start();
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
        private void MyComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
            //find control in datatemplate
            //ComponentArt.Win.UI.Input.ComboBoxItem selectedItem = MyComboBox.SelectedItem;
            //if (selectedItem != null)
            //{
            //    ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(selectedItem);
            //    _Value = ((TextBlock)selectedItem.ContentTemplate.FindName("tblEditMaChucVu", myContentPresenter)).Text;
            //    _Text = ((TextBlock)selectedItem.ContentTemplate.FindName("ItemText", myContentPresenter)).Text;
            //}

            int selectedIndex = MyComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                DataRowView drv = (DataRowView)MyComboBox.Items[selectedIndex];
                _Value = drv["MaChucVu"].ToString();
                _Text = drv["TenChucVu"].ToString();
            }
            RaiseTapEvent();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MyComboBox.SelectItem(_Text);
            int selectedIndex = MyComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                DataRowView drv = (DataRowView)MyComboBox.Items[selectedIndex];
                _Value = drv["MaChucVu"].ToString();
                _Text = drv["TenChucVu"].ToString();
            }
            t.Stop();
        }
        private void dispatcherTimer_Tick1(object sender, EventArgs e)
        {
            for (int i = 0; i < MyComboBox.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)MyComboBox.Items[i];
                if (drv["MaChucVu"].ToString().Equals(_Value))
                {
                    MyComboBox.SelectItem(MyComboBox.ComboBoxItems[i]);
                    break;
                }
            }
            t.Stop();
        }
    }
}
