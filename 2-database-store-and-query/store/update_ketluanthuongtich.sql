set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go




ALTER PROC [dbo].[update_ketluanthuongtich]
	@MaKetLuanThuongTich int ,
	@MaHoSo bigint ,
	@NgayGioGiamDinh datetime ,
	@NguoiGiamDinh nvarchar(1000),
	@VoiSuGiupDo nvarchar(1000),
	@DieuTraVien nvarchar(50) ,
	@DienThoaiDTV nvarchar(50) ,
	@TinhHinhSuViec nvarchar(max) ,
	@NghienCuuHoSoTaiLieu nvarchar(max) ,
	@ThaiDo nvarchar(500) ,
	@ChieuCao nvarchar(50) ,
	@CanNang nvarchar(50) ,
	@Mach nvarchar(50) ,
	@HuyetAp nvarchar(50) ,
	@NhietDo nvarchar(50) ,
	@NhipTho nvarchar(50) ,
	@ThuongTich nvarchar(max) ,
	@CanLamSang nvarchar(max) ,
	@DauHieuChinhQuaGiamDinh nvarchar(max) ,
	@SucKhoeGiam nvarchar(50) ,
	@TamThoi nvarchar(50) ,
	@TamThoiBangChu nvarchar(50) ,
	@VinhVien nvarchar(50) ,
	@VinhVienBangChu nvarchar(50),
	@TomTatTinhHinhSuViec nvarchar(50),
	@SucKhoeGiamBangChu nvarchar(50),
	@HoTen1 nvarchar(50),
	@DiaDiemGiamDinh nvarchar(200),
	@HoSoTaiLieu nvarchar(1000),
	@NoiDungYeuCau nvarchar(1000),
	@NghienCuuHoSoBenhAn nvarchar(1000),
	@TheTrang nvarchar(1000),
	@LamSang nvarchar(1000),
	@KhamChuyenKhoa nvarchar(1000),
	@KetQuaCanLamSang nvarchar(2000),
	@KetLuanKhac nvarchar(2000) 
AS
BEGIN
	UPDATE ketluanthuongtich 
	SET	
		MaHoSo = @MaHoSo ,
		NgayGioGiamDinh = @NgayGioGiamDinh ,
		NguoiGiamDinh = @NguoiGiamDinh ,
		VoiSuGiupDo = @VoiSuGiupDo,
		DieuTraVien = @DieuTraVien ,
		DienThoaiDTV = @DienThoaiDTV ,
		TinhHinhSuViec = @TinhHinhSuViec ,
		NghienCuuHoSoTaiLieu = @NghienCuuHoSoTaiLieu ,
		ThaiDo = @ThaiDo ,
		ChieuCao = @ChieuCao ,
		CanNang = @CanNang ,
		Mach = @Mach ,
		HuyetAp = @HuyetAp ,
		NhietDo = @NhietDo ,
		NhipTho = @NhipTho ,
		ThuongTich = @ThuongTich ,
		CanLamSang = @CanLamSang ,
		DauHieuChinhQuaGiamDinh = @DauHieuChinhQuaGiamDinh ,
		SucKhoeGiam = @SucKhoeGiam ,
		TamThoi = @TamThoi ,
		TamThoiBangChu = @TamThoiBangChu ,
		VinhVien = @VinhVien ,
		VinhVienBangChu = @VinhVienBangChu,
		TomTatTinhHinhSuViec = @TomTatTinhHinhSuViec,
		SucKhoeGiamBangChu = @SucKhoeGiamBangChu,
		HoTen1 = @HoTen1,
		DiaDiemGiamDinh = @DiaDiemGiamDinh,
		HoSoTaiLieu = @HoSoTaiLieu,
		NoiDungYeuCau = @NoiDungYeuCau,
		NghienCuuHoSoBenhAn = @NghienCuuHoSoBenhAn,
		TheTrang = @TheTrang,
		LamSang = @LamSang,
		KhamChuyenKhoa = @KhamChuyenKhoa,
		KetQuaCanLamSang = @KetQuaCanLamSang,
		KetLuanKhac = @KetLuanKhac
	WHERE
		MaKetLuanThuongTich = @MaKetLuanThuongTich
END









