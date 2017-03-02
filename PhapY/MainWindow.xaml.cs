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
using PhapY.TemplateControl;
using PhapY.SubWindows;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Markup;
using System.Xml;
using System.Windows.Threading;
using PhapY.uc;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button btnResetLayout;
        public static Menu _mainMenu;
        public static MenuItem _menuCreateUser, _menuTSX, _menuNhanVien;
        public static Grid _Container;
        public static string _UserName, _RoleName, _MaNhanVien;
        public MainWindow()
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            _Container = Container;
            _menuCreateUser = menuCreateUser;
            _menuTSX = menuTSX;
            _menuNhanVien = menuNhanVien;
            //btnResetLayout = new Button();
            //btnResetLayout.Width = 100;
            //btnResetLayout.Height = 23;
            //btnResetLayout.Content = "Reset Layout";
            //btnResetLayout.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            //btnResetLayout.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            //btnResetLayout.Margin = new Thickness(0, 5, 5, 0);
            //btnResetLayout.Click+=new RoutedEventHandler(btnResetLayout_Click);
        }
        private void print()
        {
            ((FrameworkElement)Container.Children[0]).Width = 760;
            if (Container.Children.IndexOf(btnResetLayout) == -1)
            {
                Container.Children.Add(btnResetLayout);
            }
            DispatcherTimer t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 1);
            t.Tick += new EventHandler(t_Tick1);
            t.Start();
        }
        private void printpreview()
        {
            ((FrameworkElement)Container.Children[0]).Width = 760;
            if (Container.Children.IndexOf(btnResetLayout) == -1)
            {
                Container.Children.Add(btnResetLayout);
            }
            DispatcherTimer t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 1);
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            ComponentArt.Win.UI.Data.DataGrid datagrid = FindVisualChild<ComponentArt.Win.UI.Data.DataGrid>(Container);
            var vb = new VisualBrush(datagrid);
            vb.Stretch = Stretch.Uniform;
            vb.AlignmentY = AlignmentY.Top;
            vb.ViewportUnits = BrushMappingMode.Absolute;
            vb.Viewport = new Rect(16, 16, datagrid.ActualWidth, datagrid.ActualHeight);

            PrintPreviewDialog pdlg = new PrintPreviewDialog(vb);
            pdlg.Width = 800;
            pdlg.Height = datagrid.ActualHeight / datagrid.ActualWidth * pdlg.Width + 48;
            pdlg.ShowDialog();
            ((DispatcherTimer)sender).Stop();
        }
        void t_Tick1(object sender, EventArgs e)
        {
            ComponentArt.Win.UI.Data.DataGrid datagrid = FindVisualChild<ComponentArt.Win.UI.Data.DataGrid>(Container);

            var vb = new VisualBrush(datagrid);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(16, 16, datagrid.ActualWidth, datagrid.ActualHeight));
            dc.Close();

            var printDlg = new PrintDialog();
            printDlg.UserPageRangeEnabled = true;
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(vis, "Print");
            }
            ((DispatcherTimer)sender).Stop();
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
        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            TemplateNhanvien tplNV = new TemplateNhanvien();
            Container.Children.Add(tplNV);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            TemplateHoSo tplDS = new TemplateHoSo();
            Container.Children.Add(tplDS);
        }

        private void Print_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            print();
        }

        private void btnResetLayout_Click(object sender, RoutedEventArgs e)
        {
            ((FrameworkElement)Container.Children[0]).Width = Double.NaN;
            Container.Children.Remove(btnResetLayout);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            printpreview();   
        }

        private void menuCreateUser_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var createUsers = new CreateUsers();
            Container.Children.Add(createUsers);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var login = new Login();
            Container.Children.Add(login);
            mainMenu.IsEnabled = false;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var changePW = new ChangePassword();
            Container.Children.Add(changePW);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            print();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var templateTKHS = new TemplateThongKeHoSo();
            Container.Children.Add(templateTKHS);
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var dshstt = new DanhSachHoSoTuThi();
            Container.Children.Add(dshstt);
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var templateTKHS = new TemplateThongKeTuThi();
            Container.Children.Add(templateTKHS);
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var templateTKHS = new NgayGioSuaXoa();
            Container.Children.Add(templateTKHS);
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            var windowReport = new Report();
            windowReport.ShowDialog();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                var windowReport = new ReportThuongTat();
                windowReport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            var windowReport = new ReportKhamTrinh();
            windowReport.ShowDialog();
        }
    }
}
