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
    /// Interaction logic for InBanGiamDinhPhapYTuThiKhamNgoaiKhamNgoai.xaml
    /// </summary>
    public partial class InBanGiamDinhPhapYTuThiKhamNgoai : UserControl
    {
        public InBanGiamDinhPhapYTuThiKhamNgoai()
        {
            InitializeComponent();
        }
        public InBanGiamDinhPhapYTuThiKhamNgoai(string MaHoSo)
        {
            InitializeComponent();
            var tblKLTT = new TableTuThi();
            var dv = tblKLTT.get_tuthi_by_id(MaHoSo);
            //var tblKN = new TableKhamNgoai();
            //var dv1 = tblKN.get_khamngoai(MaHoSo);
            //var tblKT = new TableKhamTrong();
            //var dv2 = tblKT.get_khamtrong(MaHoSo);
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
            //if (dv1.Count != 0)
            //    KhamNgoai.DataContext = dv1[0];
            //if (dv2.Count != 0)
            //    KhamTrong.DataContext = dv2[0];
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
