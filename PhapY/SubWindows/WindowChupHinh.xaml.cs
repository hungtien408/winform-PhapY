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
using System.Windows.Shapes;
using Microsoft.Win32;
using PhapY.App_Code;
using System.IO;
using System.Data;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowChupHinh.xaml
    /// </summary>
    public partial class WindowChupHinh : Window
    {
        string _MaHoSo, _HoTen, _NamSinh, _DiaChi, _DienThoai;
        DataView dv;
        public WindowChupHinh()
        {
            InitializeComponent();
        }
        public WindowChupHinh(string MaHoSo, string HoTen, string DiaChi, string DienThoai, string NamSinh)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            lblTenDS.Content = _HoTen = HoTen;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            lblNamSinh.Content = _NamSinh = NamSinh;
            LoadData();
            var role = MainWindow._RoleName;
            if (role != Properties.Settings.Default.Role1 && role != Properties.Settings.Default.Role2)
            {
               btnSave.Visibility = Visibility.Collapsed;
            }
        }
        private void LoadData()
        {
            TableChupHinh tblCH = new TableChupHinh();
            lstNavigation.ItemsSource = dv = tblCH.get_chuphinh_by_hoso(_MaHoSo);
            if (dv.Count != 0)
            {
                BorderImgBig.DataContext = dv[0];
            }
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.gif,*.png)|*.jpg; *.gif;*.png;";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == true)
            {
                string[] filenames = ofd.FileNames;
                for (int i = 0; i < filenames.Length; i++)
                {
                    if (!lstImagePath.Items.Contains(filenames[i]))
                    {
                        lstImagePath.Items.Add(filenames[i]);
                    }
                }
            }
        }
        public byte[] getJPGFromImageControl(byte[] b, int imageWidth)
        {
            MemoryStream memStream;
            JpegBitmapEncoder encoder;
            memStream = new MemoryStream();
            encoder = new JpegBitmapEncoder();

            var result = new BitmapImage();
            result.BeginInit();
            result.DecodePixelWidth = imageWidth;
            result.StreamSource = new MemoryStream(b);
            result.CreateOptions = BitmapCreateOptions.None;
            result.CacheOption = BitmapCacheOption.Default;
            result.EndInit();
            memStream.Close();
            memStream = new MemoryStream();
            encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(result));
            encoder.Save(memStream);
            return memStream.GetBuffer();
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            DeleteItems();
        }

        private void lstImagePath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                DeleteItems();
            }
        }
        void DeleteItems()
        {
            while (lstImagePath.SelectedItems.Count > 0)
            {
                lstImagePath.Items.Remove(lstImagePath.SelectedItem);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            TableChupHinh tblCH = new TableChupHinh();
            foreach (string path in lstImagePath.Items)
            {
                byte[] b = File.ReadAllBytes(path);
                b = getJPGFromImageControl(b, 500);
                tblCH.insert_chuphinh(_MaHoSo, b, "");
            }
            LoadData();
            lstImagePath.Items.Clear();
        }

        private void lstNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstNavigation.SelectedIndex != -1)
            {
                BorderImgBig.DataContext = dv[lstNavigation.SelectedIndex];
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xoá hình này?", "Xoá", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.OK) == MessageBoxResult.OK)
            {
                lstNavigation.SelectedIndex = -1;
                TableChupHinh tblCH = new TableChupHinh();
                //tblCH.delete_chuphinh(((Button)sender).Tag.ToString());
                LoadData();
            }
        }

        private void btnLuuRaThuMuc_Click(object sender, RoutedEventArgs e)
        {
            if (lstNavigation.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn hình!");
            }
            else
            {
                System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int count = 0;
                    foreach (DataRowView drv in lstNavigation.SelectedItems)
                    {
                        count++;
                        var index = lstNavigation.Items.IndexOf(drv);
                        var imgByte = (byte[])dv[index]["Hinh"];
                        var path = fbd.SelectedPath + "\\" + "Anh " + count + ".jpg";
                        System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                        fs.Write(imgByte, 0, imgByte.Length);
                    }
                    if (MessageBox.Show("Lưu thành công. Mở thư mục?", "Lưu thành công.", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                        System.Diagnostics.Process.Start(fbd.SelectedPath);
                }
            }
        }
    }
}
