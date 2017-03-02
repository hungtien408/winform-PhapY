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

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for TimeTextbox.xaml
    /// </summary>
    public partial class TimeTextbox : UserControl
    {
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
        "StateChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TimeTextbox));

        public static readonly DependencyProperty HoursProperty = DependencyProperty.Register(
            "Hours",
            typeof(string),
            typeof(TimeTextbox),
            new FrameworkPropertyMetadata(
                new PropertyChangedCallback(ChangeHour)));

        public static readonly DependencyProperty MinutesProperty = DependencyProperty.Register(
            "Minutes",
            typeof(string),
            typeof(TimeTextbox),
            new FrameworkPropertyMetadata(
                new PropertyChangedCallback(ChangeMinute)));

        private static System.Windows.Controls.ToolTip tt = new ToolTip();
        DispatcherTimer dt;
        public TimeTextbox()
        {
            InitializeComponent();
            tt.Foreground = Brushes.Red;
            tt.Content = "Chỉ nhập số.";
        }
        public string FullTime
        {
            get
            {
                string Hours = txtHours.Text;
                string Minutes = txtMinutes.Text;
                if (string.IsNullOrEmpty(Hours))
                {
                    Hours = "00";
                }
                if (string.IsNullOrEmpty(Minutes))
                {
                    Minutes = "00";
                }
                return Hours + ":" + Minutes;
            }
        }
        public string Hours
        {
            get
            {
                return txtHours.Text;
            }
            set
            {
                UpdateHour(value);
            }
        }
        public string Minutes
        {
            get
            {
                return txtMinutes.Text;
            }
            set
            {
                UpdateMinute(value);
            }
        }

        private static void ChangeHour(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((TimeTextbox)source).UpdateHour(e.NewValue.ToString());
            else
                ((TimeTextbox)source).UpdateHour("");
        }
        private void UpdateHour(string NewHour)
        {
            if (NewHour.Length == 1)
            {
                txtHours.Text = "0" + NewHour;
            }
            else
            {
                txtHours.Text = NewHour;
            }
        }

        private static void ChangeMinute(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((TimeTextbox)source).UpdateMinute(e.NewValue.ToString());
            else
                ((TimeTextbox)source).UpdateMinute("");
        }
        private void UpdateMinute(string NewMinute)
        {
            if (NewMinute.Length == 1)
            {
                txtMinutes.Text = "0" + NewMinute;
            }
            else
            {
                txtMinutes.Text = NewMinute;
            }
        }

        public event RoutedEventHandler StateChanged
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        // This method raises the Tap event
        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(TimeTextbox.TapEvent);
            RaiseEvent(newEventArgs);
        }
        void dt_Tick(object sender, EventArgs e)
        {
            tt.IsOpen = false;
            dt.Stop();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (txtHours.Text.Length != 0)
            {
                lblHours.Content = "";
            }
            else
            {
                lblHours.Content = "hh";
            }
            if (txtMinutes.Text.Length != 0)
            {
                lblMinutes.Content = "";
            }
            else
            {
                lblMinutes.Content = "mm";
            }
        }

        private void txtHours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.D0 && e.Key != Key.D1 && e.Key != Key.D2 && e.Key != Key.D3 && e.Key != Key.D4 && e.Key != Key.D5 && e.Key != Key.D6 && e.Key != Key.D7 && e.Key != Key.D8 && e.Key != Key.D9 && e.Key != Key.Enter && e.Key != Key.Tab && e.Key != Key.Escape && e.Key != Key.NumPad0 && e.Key != Key.NumPad1 && e.Key != Key.NumPad2 && e.Key != Key.NumPad3 && e.Key != Key.NumPad4 && e.Key != Key.NumPad5 && e.Key != Key.NumPad6 && e.Key != Key.NumPad7 && e.Key != Key.NumPad8 && e.Key != Key.NumPad9)
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
                else
                {
                    string keyValue = "";
                    int Num;
                    
                    bool isNum = Int32.TryParse(((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString(), out Num);
                    if (isNum)
                    {
                        keyValue = ((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString();
                    }
                    else
                    {
                        string keyChar = ((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString();
                        if (keyChar == "`")
                        {
                            keyValue = "0";
                        }
                        else if (keyChar == "a")
                        {
                            keyValue = "1";
                        }
                        else if (keyChar == "b")
                        {
                            keyValue = "2";
                        }
                        else if (keyChar == "c")
                        {
                            keyValue = "3";
                        }
                        else if (keyChar == "d")
                        {
                            keyValue = "4";
                        }
                        else if (keyChar == "e")
                        {
                            keyValue = "5";
                        }
                        else if (keyChar == "f")
                        {
                            keyValue = "6";
                        }
                        else if (keyChar == "g")
                        {
                            keyValue = "7";
                        }
                        else if (keyChar == "h")
                        {
                            keyValue = "8";
                        }
                        else if (keyChar == "i")
                        {
                            keyValue = "9";
                        }
                    }
                    if (keyValue != "")
                    {
                        string inputText = txtHours.Text;
                        if (string.IsNullOrEmpty(inputText))
                        {
                            inputText = keyValue;
                        }
                        else
                        {
                            inputText = inputText.Insert(txtHours.CaretIndex, keyValue);
                        }
                        if (Int32.Parse(inputText) > 23)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtHours_GotFocus(object sender, RoutedEventArgs e)
        {
            lblHours.Content = "";
            ((TextBox)sender).SelectAll();
        }
        private void txtHours_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtHours.Text.Length != 0)
            {
                lblHours.Content = "";
                if (txtHours.Text.Length < 2)
                {
                    txtHours.Text = "0" + txtHours.Text;
                }
            }
            else
            {
                lblHours.Content = "hh";
            }
            RaiseTapEvent();
        }

        private void txtMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.D0 && e.Key != Key.D1 && e.Key != Key.D2 && e.Key != Key.D3 && e.Key != Key.D4 && e.Key != Key.D5 && e.Key != Key.D6 && e.Key != Key.D7 && e.Key != Key.D8 && e.Key != Key.D9 && e.Key != Key.Enter && e.Key != Key.Tab && e.Key != Key.Escape && e.Key != Key.NumPad0 && e.Key != Key.NumPad1 && e.Key != Key.NumPad2 && e.Key != Key.NumPad3 && e.Key != Key.NumPad4 && e.Key != Key.NumPad5 && e.Key != Key.NumPad6 && e.Key != Key.NumPad7 && e.Key != Key.NumPad8 && e.Key != Key.NumPad9)
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
                else
                {
                    string keyValue = "";
                    int Num;
                    bool isNum = Int32.TryParse(((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString(), out Num);
                    if (isNum)
                    {
                        keyValue = ((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString();
                    }
                    else
                    {
                        string keyChar = ((char)KeyInterop.VirtualKeyFromKey(e.Key)).ToString();
                        if (keyChar == "`")
                        {
                            keyValue = "0";
                        }
                        else if (keyChar == "a")
                        {
                            keyValue = "1";
                        }
                        else if (keyChar == "b")
                        {
                            keyValue = "2";
                        }
                        else if (keyChar == "c")
                        {
                            keyValue = "3";
                        }
                        else if (keyChar == "d")
                        {
                            keyValue = "4";
                        }
                        else if (keyChar == "e")
                        {
                            keyValue = "5";
                        }
                        else if (keyChar == "f")
                        {
                            keyValue = "6";
                        }
                        else if (keyChar == "g")
                        {
                            keyValue = "7";
                        }
                        else if (keyChar == "h")
                        {
                            keyValue = "8";
                        }
                        else if (keyChar == "i")
                        {
                            keyValue = "9";
                        }
                    }
                    if (keyValue != "")
                    {
                        string inputText = txtMinutes.Text;
                        if (string.IsNullOrEmpty(inputText))
                        {
                            inputText = keyValue;
                        }
                        else
                        {
                            inputText = inputText.Insert(txtMinutes.CaretIndex, keyValue);
                        }
                        if (Int32.Parse(inputText) > 59)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtMinutes_GotFocus(object sender, RoutedEventArgs e)
        {
            lblMinutes.Content = "";
            ((TextBox)sender).SelectAll();
        }
        private void txtMinutes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMinutes.Text.Length != 0)
            {
                lblMinutes.Content = "";
                if (txtMinutes.Text.Length < 2)
                {
                    txtMinutes.Text = "0" + txtMinutes.Text;
                }
            }
            else
            {
                lblMinutes.Content = "mm";
            }
            RaiseTapEvent();
        }

        private void cbbAMPM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RaiseTapEvent();
        }
    }
}
