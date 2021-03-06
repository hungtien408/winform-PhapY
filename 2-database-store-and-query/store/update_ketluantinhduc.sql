set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go










ALTER PROC [dbo].[update_ketluantinhduc]
	(
		@MaKetLuanTinhDuc int,
		@MaHoSo bigint,
		@NguoiGiamDinh nvarchar(1000),
		@NgayGioGiamDinh datetime,
		@VoiSuGiupDo nvarchar(1000),
		@DieuTraVien nvarchar(50),
		@DienThoaiDTV nvarchar(50),
		@TinhHinhSuViec nvarchar(max),
		@NghienCuuHoSoTaiLieu nvarchar(max),
		@LamSang nvarchar(1000),
		@ThaiDo nvarchar(500),
		@ChieuCao nvarchar(500),
		@CanNang nvarchar(500),
		@HuyetAp nvarchar(500),
		@Mach nvarchar(500),
		@NhietDo nvarchar(500),
		@QuanAo nvarchar(500),
		@LongMu nvarchar(500),
		@MoiLon nvarchar(500),
		@MoiBe nvarchar(500),
		@AmHo nvarchar(500),
		@MangTrinh nvarchar(500),
		@AmDao nvarchar(500),
		@TangSinhMon nvarchar(500),
		@HauMon nvarchar(500),
		@Dau nvarchar(500),
		@Co nvarchar(500),
		@Nguc nvarchar(500),
		@Dui nvarchar(500),
		@Lung nvarchar(500),
		@Mong nvarchar(500),
		@TayChan nvarchar(500),
		@MaSo nvarchar(20),
		@LayMauPhetDichAmDao bit,
		@SoMauPhetDichAmDao nvarchar(5),
		@Phodphatase nvarchar(100),
		@Christmas nvarchar(100),
		@LuuMauPhetDichAmDao bit,
		@LayMau bit,
		@QuetNiemMac bit,
		@SieuAmBung bit,
		@DauHieu nvarchar(max),
		@KLKhac nvarchar(max),
		@KhongThucHienPhodphatase bit,
		@KhongThucHienChristmas bit,
		@XetNghiemHIV bit,
		@HoTen1 nvarchar(50),
		@DiaDiemGiamDinh nvarchar(200),
		@HoSoTaiLieu nvarchar(1000),
		@NoiDungYeuCau nvarchar(1000),
		@NghienCuuHoSoBenhAn nvarchar(1000),
		@TheTrang nvarchar(1000),
		@KhamChuyenKhoa nvarchar(1000),
		@KetQuaCanLamSang nvarchar(2000)
	)
AS
BEGIN
	update ketluantinhduc set
			MaHoSo = @MaHoSo,
			NguoiGiamDinh = @NguoiGiamDinh,
			NgayGioGiamDinh = @NgayGioGiamDinh,
			VoiSuGiupDo = @VoiSuGiupDo,
			DieuTraVien = @DieuTraVien,
			DienThoaiDTV = @DienThoaiDTV,
			TinhHinhSuViec = @TinhHinhSuViec,
			NghienCuuHoSoTaiLieu = @NghienCuuHoSoTaiLieu,
			LamSang = @LamSang,
			ThaiDo = @ThaiDo,
			ChieuCao = @ChieuCao,
			CanNang = @CanNang,
			HuyetAp = @HuyetAp,
			Mach = @Mach,
			NhietDo = @NhietDo,
			QuanAo = @QuanAo,
			LongMu = @LongMu,
			MoiLon = @MoiLon,
			MoiBe = @MoiBe,
			AmHo = @AmHo,
			MangTrinh = @MangTrinh,
			AmDao = @AmDao,
			TangSinhMon = @TangSinhMon,
			HauMon = @HauMon,
			Dau = @Dau,
			Co = @Co,
			Nguc = @Nguc,
			Dui = @Dui,
			Lung = @Lung,
			Mong = @Mong,
			TayChan = @TayChan,
			MaSo = @MaSo,
			LayMauPhetDichAmDao = @LayMauPhetDichAmDao,
			SoMauPhetDichAmDao = @SoMauPhetDichAmDao,
			Phodphatase = @Phodphatase,
			Christmas = @Christmas,
			LuuMauPhetDichAmDao = @LuuMauPhetDichAmDao,
			LayMau = @LayMau,
			QuetNiemMac = @QuetNiemMac,
			SieuAmBung = @SieuAmBung,
			DauHieu = @DauHieu,
			KLKhac = @KLKhac,
			KhongThucHienPhodphatase = @KhongThucHienPhodphatase,
			KhongThucHienChristmas = @KhongThucHienChristmas,
			XetNghiemHIV = @XetNghiemHIV,
			HoTen1 = @HoTen1,
			DiaDiemGiamDinh = @DiaDiemGiamDinh,
			HoSoTaiLieu = @HoSoTaiLieu,
			NoiDungYeuCau = @NoiDungYeuCau,
			NghienCuuHoSoBenhAn = @NghienCuuHoSoBenhAn,
			TheTrang = @TheTrang,
			KhamChuyenKhoa = @KhamChuyenKhoa,
			KetQuaCanLamSang = @KetQuaCanLamSang
	where MaKetLuanTinhDuc = @MaKetLuanTinhDuc
END










