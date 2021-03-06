set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

















ALTER PROC [dbo].[insert_tuthi]
		@SoHoSo nvarchar(50),
		@QDTCGDSo nvarchar(50),
		@CoQuanTrungCau nvarchar(100),
		@TinhThanh nvarchar(100),
		@KyNgay datetime,
		@HoTen nvarchar(50),
		@HoTen1 nvarchar(50),
		@NamSinh nvarchar(10),
		@GioiTinh bit,
		@DiaChi nvarchar(200),
		@HinhDuongSu image,
		@QuocTich nvarchar(50),
		@NguoiGiamDinh nvarchar(1000),
		@NgayBatDau datetime,
		@NgayKetThuc datetime,
		@DieuTraVien nvarchar(50),
		@DienThoaiDTV nvarchar(50),
		@DiaDiemGiamDinh nvarchar(200),
		@DieuKienAnhSangThoiTiet nvarchar(200),
		@NguoiChungKien nvarchar(1000),
		@NoiDungSuViec nvarchar(2000),
		@TienSuCaNhan nvarchar(1000),
		@NhanDangVaTinhTrangTuThi nvarchar(2000),
		@CacDauVetThuongTich nvarchar(max),
		@KhamTrong nvarchar(max),
		@SoViThe1 nvarchar(10),
		@SoViThe2 nvarchar(10),
		@XetNghiemTeBao_MoBenhHoc nvarchar(max),
		@CacXetNghiemKhac nvarchar(1000),
		@ChanDoanYPhap nvarchar(max),
		@NguyenNhanChet nvarchar(1000),
		@PhuMo1 nvarchar(100),
		@PhuMo2 nvarchar(100),
		@GiamDinhVien1 nvarchar(100),
		@GiamDinhVien2 nvarchar(100),
		@TrinhDoVanHoa nvarchar(100),
		@DanToc nvarchar(50),
		@TonGiao nvarchar(50),
		@NgheNghiep nvarchar(100),
		@XayRa nvarchar(100),
		@Tai nvarchar(100),
		@KetQuaCanLamSang nvarchar(2000),
		@KetLuanKhac nvarchar(2000),
		@DocChat nvarchar(max),
		@ADN nvarchar(max),
		@HoSoTaiLieu nvarchar(1000),
		@NoiDungYeuCau nvarchar(1000),
		@NghienCuuHoSoBenhAn nvarchar(1000)
	
AS
BEGIN
	INSERT INTO tuthi(
		SoHoSo,
		QDTCGDSo,
		CoQuanTrungCau,
		TinhThanh,
		KyNgay,
		HoTen,
		HoTen1,
		NamSinh,
		GioiTinh,
		DiaChi,
		HinhDuongSu,
		QuocTich,
		NguoiGiamDinh,
		NgayBatDau,
		NgayKetThuc,
		DieuTraVien,
		DienThoaiDTV,
		DiaDiemGiamDinh,
		DieuKienAnhSangThoiTiet,
		NguoiChungKien,
		NoiDungSuViec,
		TienSuCaNhan,
		NhanDangVaTinhTrangTuThi,
		CacDauVetThuongTich,
		KhamTrong,
		SoViThe1,
		SoViThe2,
		XetNghiemTeBao_MoBenhHoc,
		CacXetNghiemKhac,
		ChanDoanYPhap,
		NguyenNhanChet,
		PhuMo1,
		PhuMo2,
		GiamDinhVien1,
		GiamDinhVien2,
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
		NghienCuuHoSoBenhAn,
		Available
	) VALUES(
		@SoHoSo,
		@QDTCGDSo,
		@CoQuanTrungCau,
		@TinhThanh,
		@KyNgay,
		@HoTen,
		@HoTen1,
		@NamSinh,
		@GioiTinh,
		@DiaChi,
		@HinhDuongSu,
		@QuocTich,
		@NguoiGiamDinh,
		@NgayBatDau,
		@NgayKetThuc,
		@DieuTraVien,
		@DienThoaiDTV,
		@DiaDiemGiamDinh,
		@DieuKienAnhSangThoiTiet,
		@NguoiChungKien,
		@NoiDungSuViec,
		@TienSuCaNhan,
		@NhanDangVaTinhTrangTuThi,
		@CacDauVetThuongTich,
		@KhamTrong,
		@SoViThe1,
		@SoViThe2,
		@XetNghiemTeBao_MoBenhHoc,
		@CacXetNghiemKhac,
		@ChanDoanYPhap,
		@NguyenNhanChet,
		@PhuMo1,
		@PhuMo2,
		@GiamDinhVien1,
		@GiamDinhVien2,
		@TrinhDoVanHoa,
		@DanToc,
		@TonGiao,
		@NgheNghiep,
		@XayRa,
		@Tai,
		@KetQuaCanLamSang,
		@KetLuanKhac,
		@DocChat,
		@ADN,
		@HoSoTaiLieu,
		@NoiDungYeuCau,
		@NghienCuuHoSoBenhAn,
		'1'
	)
	DECLARE @ID int
	SELECT	@ID = SCOPE_IDENTITY();
	insert into PhuLucTuThi(MaHoSo) values(@ID)
END
















