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
using System.DirectoryServices;
using System.Windows.Threading;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for LogonServer.xaml
    /// </summary>
    public partial class LogonServer : UserControl
    {
        public LogonServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.ServerName = "\\\\DELL-PC";
            //Properties.Settings.Default.Save();
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Properties.Settings.Default.ServerName + @"\PhapYApplication");
            //if (!di.Exists)
            //{
            //    NetworkDrive oNetDrive = new NetworkDrive();
            //    try
            //    {
            //        oNetDrive.LocalDrive = "Z:";
            //        oNetDrive.ShareName = Properties.Settings.Default.ServerName + @"\D$";
            //        oNetDrive.MapDrive(Properties.Settings.Default.UserName, Properties.Settings.Default.Password);
            //        oNetDrive.UnMapDrive();
            //        System.IO.File.Copy("d:\\images.jpg", "Z:\\b.jpg");
            //    }
            //    catch (Exception err)
            //    {
            //        textBox1.Text = err.GetType().ToString() + " - " + err.Message;
            //    }
            //    oNetDrive = null;
            //}
            //else
            //{
            //    MessageBox.Show("exist");
            //}
            
            List<string> list = GetComputersOnNetwork();
            listBox1.ItemsSource = list;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NetworkDrive oNetDrive = new NetworkDrive();
            oNetDrive.UnMapDrive();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Form f = new System.Windows.Forms.Form();
            NetworkDrive oNetDrive = new NetworkDrive();
            oNetDrive.ShowConnectDialog(f);
        }

        public List<string> GetComputersOnNetwork()
        {
            List<string> list = new List<string>();
            using (DirectoryEntry root = new DirectoryEntry("WinNT://WORKGROUP"))
            {
                foreach (DirectoryEntry computers in root.Children)
                {
                    if ((!computers.Name.Contains("Schema")))
                    {
                        list.Add(computers.Name);
                        //foreach(PropertyValueCollection pvc in computers.Properties)
                        //{
                        //    //MessageBox.Show(pvc.PropertyName);
                        //    list.Add(pvc.PropertyName);
                        //}
                    }
                }
            }
            return list;
        }
    }
}
