using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhapY.App_Code
{
    public class TablePhuLucThuongTich
    {
        string connectionString = Common.ConnectionString;
        public DataView get_phulucthuongtich(string MaHoSo)
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_phulucthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }

        public void update_phulucthuongtich(
            string MaHoSo,
	        string BanGiamDinhYPhap,
	        string BanKetLuanThuongTich,
	        string QuyetDinhTrungCauGiamDinh,
	        string BanSaoCMNDHoChieu,
	        string GiayRavien,
	        string GiayChungNhanThuongTich,
	        string BienBanXemXetDauVetCoThe,
	        string ToaThuoc,
	        string YChung,
	        string XQ,
	        string XQA,
	        string XQB,
	        string EEG,
	        string EMG,
	        string ECG,
	        string MRI,
	        string SieuAm,
	        string CTScanner,
            string CTScannerInput,
	        string XetNghiem,
	        string NoiSoi,
	        string TMH,
	        string RHM,
	        string CTCH,
	        string Mat,
	        string NoiTimMach,
	        string NoiTieuHoa,
	        string NoiTiet,
	        string NoiThanKinh,
	        string NoiHoHap,
	        string Lao,
	        string SoDoPhacHoa,
	        string Chup,
	        string SoKhamBenh,
	        string BenhAnTomTat,
	        string BanSaoHoSoBenhAn,
	        string BienBanGiaoNhanTaiLieuGiamDinh,
	        string GiayCamKetKhongKhamChuyenKhoa,
            string GiayCamKetInput,
	        string CongVanSo,
	        string NoiDungCongVan,
	        string Khac,
	        string NoiDungKhac,
	        string TongCong,
            string BenhAnCapCuu,
            string BenhAnNgoaiChuan,
            string MRIInput,
            string CNHH
            )
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("update_phulucthuongtich", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
            cmd.Parameters.AddWithValue("@BanGiamDinhYPhap", BanGiamDinhYPhap);
            cmd.Parameters.AddWithValue("@BanKetLuanThuongTich", BanKetLuanThuongTich);
            cmd.Parameters.AddWithValue("@QuyetDinhTrungCauGiamDinh", QuyetDinhTrungCauGiamDinh);
            cmd.Parameters.AddWithValue("@BanSaoCMNDHoChieu", BanSaoCMNDHoChieu);
            cmd.Parameters.AddWithValue("@GiayRavien", GiayRavien);
            cmd.Parameters.AddWithValue("@GiayChungNhanThuongTich", GiayChungNhanThuongTich);
            cmd.Parameters.AddWithValue("@BienBanXemXetDauVetCoThe", BienBanXemXetDauVetCoThe);
            cmd.Parameters.AddWithValue("@ToaThuoc", ToaThuoc);
            cmd.Parameters.AddWithValue("@YChung", YChung);
            cmd.Parameters.AddWithValue("@XQ", XQ);
            cmd.Parameters.AddWithValue("@XQA", XQA);
            cmd.Parameters.AddWithValue("@XQB", XQB);
            cmd.Parameters.AddWithValue("@EEG", EEG);
            cmd.Parameters.AddWithValue("@EMG", EMG);
            cmd.Parameters.AddWithValue("@ECG", ECG);
            cmd.Parameters.AddWithValue("@MRI", MRI);
            cmd.Parameters.AddWithValue("@SieuAm", SieuAm);
            cmd.Parameters.AddWithValue("@CTScanner", CTScanner);
            cmd.Parameters.AddWithValue("@CTScannerInput", CTScannerInput);
            cmd.Parameters.AddWithValue("@XetNghiem", XetNghiem);
            cmd.Parameters.AddWithValue("@NoiSoi", NoiSoi);
            cmd.Parameters.AddWithValue("@TMH", TMH);
            cmd.Parameters.AddWithValue("@RHM", RHM);
            cmd.Parameters.AddWithValue("@CTCH", CTCH);
            cmd.Parameters.AddWithValue("@Mat", Mat);
            cmd.Parameters.AddWithValue("@NoiTimMach", NoiTimMach);
            cmd.Parameters.AddWithValue("@NoiTieuHoa", NoiTieuHoa);
            cmd.Parameters.AddWithValue("@NoiTiet", NoiTiet);
            cmd.Parameters.AddWithValue("@NoiThanKinh", NoiThanKinh);
            cmd.Parameters.AddWithValue("@NoiHoHap", NoiHoHap);
            cmd.Parameters.AddWithValue("@Lao", Lao);
            cmd.Parameters.AddWithValue("@SoDoPhacHoa", SoDoPhacHoa);
            cmd.Parameters.AddWithValue("@Chup", Chup);
            cmd.Parameters.AddWithValue("@SoKhamBenh", SoKhamBenh);
            cmd.Parameters.AddWithValue("@BenhAnTomTat", BenhAnTomTat);
            cmd.Parameters.AddWithValue("@BanSaoHoSoBenhAn", BanSaoHoSoBenhAn);
            cmd.Parameters.AddWithValue("@BienBanGiaoNhanTaiLieuGiamDinh", BienBanGiaoNhanTaiLieuGiamDinh);
            cmd.Parameters.AddWithValue("@GiayCamKetKhongKhamChuyenKhoa", GiayCamKetKhongKhamChuyenKhoa);
            cmd.Parameters.AddWithValue("@GiayCamKetInput", GiayCamKetInput);
            cmd.Parameters.AddWithValue("@CongVanSo", CongVanSo);
            cmd.Parameters.AddWithValue("@NoiDungCongVan", NoiDungCongVan);
            cmd.Parameters.AddWithValue("@Khac", Khac);
            cmd.Parameters.AddWithValue("@NoiDungKhac", NoiDungKhac);
            cmd.Parameters.AddWithValue("@TongCong", TongCong);
            cmd.Parameters.AddWithValue("@BenhAnCapCuu", BenhAnCapCuu);
            cmd.Parameters.AddWithValue("@BenhAnNgoaiChuan", BenhAnNgoaiChuan);
            cmd.Parameters.AddWithValue("@MRIInput", MRIInput);
            cmd.Parameters.AddWithValue("@CNHH", CNHH);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }

       
    }
}
