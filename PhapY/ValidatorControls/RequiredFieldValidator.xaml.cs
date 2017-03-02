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

namespace PhapY.ValidatorControls
{
    /// <summary>
    /// Interaction logic for RequiredFieldValidator.xaml
    /// </summary>
    public partial class RequiredFieldValidator : UserControl
    {
        TextBox _txt;
        string _ErrorMessage = "Required";
        ToolTip tt = new ToolTip();
        DispatcherTimer dt;
        public RequiredFieldValidator()
        {
            InitializeComponent();
            tt.Content = _ErrorMessage;
            tt.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;
            tt.PlacementTarget = image1;
            tt.HorizontalOffset = 20;
            tt.VerticalOffset = 20;
            image1.ToolTip = tt;

            dt = new DispatcherTimer(DispatcherPriority.Normal);
            dt.Interval = TimeSpan.FromMilliseconds(3000);
            dt.Tick += new EventHandler(dt_Tick);
        }
        public TextBox ControlToValidate
        {
            get
            {
                return _txt;
            }
            set
            {
                _txt = value;
                _txt.TextChanged += TextChanged;
                _txt.LostFocus += TextChanged;
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }
            set
            {
                _ErrorMessage = value;
            }
        }
        void dt_Tick(object sender, EventArgs e)
        {
            tt.IsOpen = false;
            dt.Stop();
        }
        private void TextChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_txt.Text))
            {
                tt.IsOpen = true;
                dt.Start();
                image1.Visibility = Visibility.Visible;
            }
            else
            {
                image1.Visibility = Visibility.Hidden;
            }
        }

    }
}
