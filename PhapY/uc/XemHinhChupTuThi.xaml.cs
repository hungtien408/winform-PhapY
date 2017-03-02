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
using System.Data;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for XemHinhChup.xaml
    /// </summary>
    public partial class XemHinhChupTuThi : UserControl
    {
        string _MaHoSo;
        DataView dv;
        public XemHinhChupTuThi()
        {
            InitializeComponent();
        }
        public XemHinhChupTuThi(string MaHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            LoadData();
        }
        public void LoadData()
        {
            var tblChupHinh = new Tablechuphinhtuthi();
            lstViewChooseImg.ItemsSource = dv = tblChupHinh.get_thutuchonhinhtuthi(_MaHoSo);
            if (dv.Count == 0)
                btnSave.IsEnabled = false;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataRowView drv in dv)
                {
                    var imgByte = (byte[])drv["Hinh"];
                    var index = drv["ThuTuChon"].ToString();
                    var path = fbd.SelectedPath + "\\" + "Anh " + index + ".jpg";
                    System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    fs.Write(imgByte, 0, imgByte.Length);
                }
                if (MessageBox.Show("Lưu thành công. Mở thư mục?", "Lưu thành công.", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                    System.Diagnostics.Process.Start(fbd.SelectedPath);
            }
        }
    }
}
