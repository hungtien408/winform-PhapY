set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go










ALTER procedure [dbo].[get_tuthi]
as
begin
	SELECT 
		MaHoSo,
		SoHoSo,
		dbo.SoHoSo_NumberOnly(SoHoSo) SoHoSoSub,
		QDTCGDSo,
		CoQuanTrungCau,
		HinhDuongSu,
		HoTen,
		HoTen1,
		GioiTinh,
		NamSinh,
		DiaChi,
		DienThoaiDTV,
		NgayBatDau,
		DangOPhong,
		TinhTrangHoSo,
		ChanDoanYPhap,
		TrinhDoVanHoa,
		DanToc,
		TonGiao,
		NgheNghiep,
		XayRa,
		Tai,
		KetQuaCanLamSang,
		KetLuanKhac,
		DocChat,
		ADN,
		HoSoTaiLieu,
		NoiDungYeuCau,
		NghienCuuHoSoBenhAn
	
	FROM tuthi where Available = '1' ORDER BY KyNgay desc
end










