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
using System.Globalization;
using System.Threading;
using PhapY.App_Code;
using System.IO;
using PhapY.uc;
using System.Data;
using PhapY.SubWindows;

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for XemTuThi.xaml
    /// </summary>
    public partial class XemTuThi : UserControl
    {
        string _MaHoSo;
        DataView dv;
        public XemTuThi()
        {
            InitializeComponent();
        }
        public XemTuThi(string MaHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            LoadData();
        }
        private void LoadData()
        {
            TableTuThi tblKLTT = new TableTuThi();
            dv = tblKLTT.get_tuthi_by_id(_MaHoSo);
            
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                _MaHoSo = dv[0]["MaHoSo"].ToString();
            }
        }
        private void print()
        {
            var vb = new VisualBrush(scroll1);

            var vis = new DrawingVisual();
            var dc = vis.RenderOpen();

            dc.DrawRectangle(vb, null, new Rect(16, 16, scroll1.ActualWidth, scroll1.ActualHeight));
            dc.Close();

            var printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == true)
            {
                printDlg.PrintVisual(vis, "Print");
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            print();
        }

        
        public byte[] getJPGFromImageControl(BitmapImage imageC, int imageWidth)
        {
            MemoryStream memStream;
            JpegBitmapEncoder encoder;
            memStream = new MemoryStream();
            encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);

            var result = new BitmapImage();
            result.BeginInit();
            result.DecodePixelWidth = imageWidth;
            result.StreamSource = new MemoryStream(memStream.GetBuffer());
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

        //private void btnBrowse_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
        //    ofd.Filter = "Image files (*.jpg, *.gif,*.png,*.bmp)|*.jpg; *.gif;*.png;*.bmp";
        //    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        ImageSource imgS = new BitmapImage(new Uri(ofd.FileName));
        //        imgHinhDuongSu.Source = imgS;
        //        //change the status when image is changed
        //        tblCheckImageStatus.Text = "1";
        //    }
        //}

        

        

       
    }
}
