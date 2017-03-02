using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Globalization;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;
using PhapY.App_Code;
using System.Reflection;
using System.Windows.Markup;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<TextBox> FilterTextBoxes = new List<TextBox>();
        public static ScrollViewer sv;
        public App()
        {
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
        }
        public virtual void ComboBox_SelectionFinalized(object sender, ComponentArt.Win.UI.Input.ComboBoxEventArgs cbea)
        {
           
        }

        public static void ResetFilter()
        {
            foreach (TextBox txt in FilterTextBoxes)
            {
                txt.Clear();
            }
            FilterTextBoxes.Clear();
        }

        private void FilterValue_GotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (!FilterTextBoxes.Contains((TextBox)sender))
            {
                FilterTextBoxes.Add((TextBox)sender);
            }
        }

        private void RowsScroller_Initialized(object sender, EventArgs e)
        {
            sv = (ScrollViewer)sender;
        }

        public static void ThemHanhDong(
                string EmpID,
                string HanhDong,
                string MaHoSo,
                string SoHoSo,
                string NgaySua,
                string QDTCGDSo
            )
        {
            var tbl = new TableNgayGioSuaXoa();
            tbl.insert_ngaygiosuaxoa(
                EmpID,
                HanhDong,
                MaHoSo,
                SoHoSo,
                NgaySua,
                QDTCGDSo
                );
        }

        private void App_Unhandle(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                e.Handled = false;
            }
            else
            {
                string msg = string.Format("Lỗi: {0}", e.Exception.Message);
                MessageBox.Show(msg);
                var Err = new CreateLogFiles();
                Err.ErrorLog(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), e.Exception.TargetSite.ToString() + " Lỗi: " + e.Exception.Message.ToString());
                e.Handled = true;
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception)e.ExceptionObject;
            if (System.Diagnostics.Debugger.IsAttached)
            {

            }
            else
            {
                string msg = string.Format("Lỗi: {0}", ex.Message);
                MessageBox.Show(msg);
                var Err = new CreateLogFiles();
                Err.ErrorLog(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ex.TargetSite.ToString() + " Lỗi: " + ex.Message.ToString());
            }
        }
        //private void RowsScroller_Initialized(object sender, EventArgs e)
        //{
        //    DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(ScrollViewer.ComputedVerticalScrollBarVisibilityProperty, typeof(ScrollViewer));
        //    descriptor.AddValueChanged(sender, new EventHandler(VerticalScrollBarIsChanged));
        //}
        //private void VerticalScrollBarIsChanged(object sender, EventArgs e)
        //{
        //    if (((ScrollViewer)sender).ComputedVerticalScrollBarVisibility == Visibility.Visible)
        //    {
        //        //Visible is set true
        //    }
        //    else
        //    {
        //        //Visible is set false
        //    }
        //}

    }
}
