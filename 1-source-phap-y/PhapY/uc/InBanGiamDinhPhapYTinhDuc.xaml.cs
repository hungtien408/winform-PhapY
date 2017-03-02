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
    /// Interaction logic for InBanGiamDinhPhapYTinhDuc.xaml
    /// </summary>
    public partial class InBanGiamDinhPhapYTinhDuc : UserControl
    {
        object _DataContext;
        string _MaHoSo, _MaKetLuanThuongTich;
        DataView dv;
        public InBanGiamDinhPhapYTinhDuc()
        {
            InitializeComponent();
        }
        public InBanGiamDinhPhapYTinhDuc(string MaHoSo, object DataContext)
        {
            InitializeComponent();

            Container.DataContext = DataContext;
            lblNgay.Content = string.Format("{0:dd}", DateTime.Now);
            lblThang.Content = string.Format("{0:MM}", DateTime.Now);
            lblNam.Content = string.Format("{0:yyyy}", DateTime.Now);
            _DataContext = DataContext;
            _MaHoSo = MaHoSo;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Container.DataContext = _DataContext;
                TableKetLuanTinhDuc tblKLTT = new TableKetLuanTinhDuc();
                dv = tblKLTT.get_ketluantinhduc_by_hoso(_MaHoSo);
                Container.DataContext = dv[0];
                _MaKetLuanThuongTich = dv[0]["MaKetLuanTinhDuc"].ToString();
                string KhongThucHienPhodphatase = dv[0]["KhongThucHienPhodphatase"].ToString();
                string KhongThucHienChristmas = dv[0]["KhongThucHienChristmas"].ToString();
                string Phodphatase = dv[0]["Phodphatase"].ToString();
                string Christmas = dv[0]["Christmas"].ToString();
                string SieuAm = dv[0]["SieuAmBung"].ToString();
                string XetNghiemHIV = dv[0]["XetNghiemHIV"].ToString();
                string LuuMauPhetDichAmDao = dv[0]["LuuMauPhetDichAmDao"].ToString();

                string LayMau = dv[0]["LayMau"].ToString();
                string QuetNiemMac = dv[0]["QuetNiemMac"].ToString();
                string LayMauPhetDichAmDao = dv[0]["LayMauPhetDichAmDao"].ToString();
                //if (KhongThucHienChristmas == "True" && KhongThucHienPhodphatase == "True")
                //{
                //    lblPhetDichAmDao.Height = 0;
                //}
                //else
                //{
                //    if (string.IsNullOrEmpty(Phodphatase) && string.IsNullOrEmpty(Christmas))
                //    {
                //        lblPhetDichAmDao.Height = 0;
                //    }
                //}
                if (SieuAm == "False")
                    lblSieuAm.Height = 0;
                if (XetNghiemHIV == "False")
                    lblXetNghiemHIV.Height = 0;
                if (LuuMauPhetDichAmDao == "False")
                {
                    lblLuuMauPhetDich.Height = 0;
                    lblLayMauVaLuuMau.Height = 0;
                    lblQuetNiemMacMaVaLuuMau.Height = 0;
                    lblPhetDichAmDao.Height = 0;
                    txtPhetDichAmDao.Height = 0;
                }
                else
                {
                    if(LayMau == "False")
                        lblLayMauVaLuuMau.Height = 0;
                    if(QuetNiemMac == "False")
                        lblQuetNiemMacMaVaLuuMau.Height = 0;
                    if (LayMauPhetDichAmDao == "False")
                    {
                        lblPhetDichAmDao.Height = 0;
                        txtPhetDichAmDao.Height = 0;
                    }
                        
                }

                if (bool.Parse(dv[0]["GioiTinh"].ToString()))
                {
                    chkNam.IsChecked = true;
                }
                else
                {
                    chkNu.IsChecked = true;
                }
            }
            catch { }
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
            if (e.NewSize.Width > 210)
            {
                pnlTai.Height = 0;
                pnlTai1.ClearValue(HeightProperty);
            }
        }
    }
}
