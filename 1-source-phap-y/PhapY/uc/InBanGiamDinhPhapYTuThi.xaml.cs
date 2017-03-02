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

namespace PhapY.uc
{
    /// <summary>
    /// Interaction logic for InBanGiamDinhPhapYTuThi.xaml
    /// </summary>
    public partial class InBanGiamDinhPhapYTuThi : UserControl
    {
        public InBanGiamDinhPhapYTuThi()
        {
            InitializeComponent();
        }
        public InBanGiamDinhPhapYTuThi(string MaHoSo)
        {
            InitializeComponent();
            var tblKLTT = new TableTuThi();
            var dv = tblKLTT.get_tuthi_by_id(MaHoSo);
            if (dv.Count != 0)
            {
                Container.DataContext = dv[0];
                //if (string.IsNullOrEmpty(dv[0]["XetNghiemTeBao_MoBenhHoc"].ToString().Trim())
                //    && string.IsNullOrEmpty(dv[0]["DocChat"].ToString().Trim())
                //    && string.IsNullOrEmpty(dv[0]["ADN"].ToString().Trim())
                //    && string.IsNullOrEmpty(dv[0]["CacXetNghiemKhac"].ToString().Trim()))
                //{
                //    tblCanLamSang.Text = "                              Không";
                //}
            }
            lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
            lblThang.Content = string.Format("{0:MM}", DateTime.Now);
            lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);
        }
        public string Ngay
        {
            set
            {
                lblNgay.Content = value;
            }
        }
        public string Thang
        {
            set
            {
                lblThang.Content = value;
            }
        }
        public string Nam
        {
            set
            {
                lblNam.Content = value;
            }
        }

        private void tblDiaChi_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Height > 20)
            {
                tblDiaChi.TextAlignment = TextAlignment.Justify;
            }
        }

        private void lblDiaDiemGiamDinh_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //if (e.NewSize.Width > 210)
            //{
            //    pnlTai.Height = 0;
            //    pnlTai1.ClearValue(HeightProperty);
            //}
        }
    }
}
