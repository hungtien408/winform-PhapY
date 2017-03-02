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
    /// Interaction logic for InBanGiamDinhPhapYThuongTatQHS.xaml
    /// </summary>
    public partial class InBanGiamDinhPhapYThuongTatQHS : UserControl
    {
        object _DataContext;
        string _MaHoSo, _MaKetLuanThuongTich;
        DataView dv;
        public InBanGiamDinhPhapYThuongTatQHS()
        {
            InitializeComponent();
        }
        public InBanGiamDinhPhapYThuongTatQHS(string MaHoSo, object DataContext)
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
                TableKetLuanThuongTich tblKLTT = new TableKetLuanThuongTich();
                dv = tblKLTT.get_ketluanthuongtich_by_hoso(_MaHoSo);
                Container.DataContext = dv[0];
                _MaKetLuanThuongTich = dv[0]["MaKetLuanThuongTich"].ToString();
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
    }
}
