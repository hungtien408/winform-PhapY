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
using System.Windows.Threading;

namespace PhapY.Controls
{
    /// <summary>
    /// Interaction logic for NumericTextbox.xaml
    /// </summary>
    public partial class NumericTextbox : UserControl
    {
        private static System.Windows.Controls.ToolTip tt = new ToolTip();
        DispatcherTimer dt;
        public NumericTextbox()
        {
            InitializeComponent();
            tt.Foreground = Brushes.Red;
            tt.Content = "Chỉ nhập số.";
        }

        public string Text
        {
            get
            {
                return textbox1.Text;
            }
            set
            {
                textbox1.Text = value;
            }
        }

        void dt_Tick(object sender, EventArgs e)
        {
            tt.IsOpen = false;
            dt.Stop();
        }

        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.D0 && e.Key != Key.D1 && e.Key != Key.D2 && e.Key != Key.D3 && e.Key != Key.D4 && e.Key != Key.D5 && e.Key != Key.D6 && e.Key != Key.D7 && e.Key != Key.D8 && e.Key != Key.D9 && e.Key != Key.Enter && e.Key != Key.Tab && e.Key != Key.Escape)
            {
                if (dt != null)
                {
                    dt.Stop();
                }
                e.Handled = true;
                dt = new DispatcherTimer(DispatcherPriority.Normal);
                dt.Interval = TimeSpan.FromMilliseconds(1000);
                dt.Tick += new EventHandler(dt_Tick);
                dt.Start();
                tt.IsOpen = true;
            }
            else
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    e.Handled = true;
                }
            }
        }

        private string formatCurrency(string input)
        {
            try
            {
                input = input.Replace(".", "");
                if (input != "")
                {
                    int value = Int32.Parse(input);
                    input = string.Format("{0:C0}", value).Replace(",", ".").Replace("$", "");
                }
            }
            catch { }
            return input;
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = ((TextBox)sender);
            string text = txt.Text;
            txt.Text = formatCurrency(text);
            txt.CaretIndex = txt.Text.Length;
        }

        private void textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
