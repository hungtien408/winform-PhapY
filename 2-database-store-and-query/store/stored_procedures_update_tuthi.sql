USE [DBPhapY]
GO
/****** Object:  StoredProcedure [dbo].[update_tuthi]    Script Date: 10/28/2014 21:27:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








ALTER PROC [dbo].[update_tuthi]
		@MaHoSo bigint,
		@SoHoSo nvarchar(50),
		@QDTCGDSo nvarchar(50),
		@CoQuanTrungCau nvarchar(100),
		@TinhThanh nvarchar(100),
		@KyNgay datetime,
		@HoTen nvarchar(50),
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
		@DauHieu nvarchar(2000),
		@KetLuanKhac nvarchar(2000)
	
AS
BEGIN
	update tuthi set
		SoHoSo = @SoHoSo,
		QDTCGDSo = @QDTCGDSo,
		CoQuanTrungCau = @CoQuanTrungCau,
		TinhThanh = @TinhThanh,
		KyNgay = @KyNgay,
		HoTen = @HoTen,
		NamSinh = @NamSinh,
		GioiTinh = @GioiTinh,
		DiaChi = @DiaChi,
		QuocTich = @QuocTich,
		NguoiGiamDinh = @NguoiGiamDinh,
		NgayBatDau = @NgayBatDau,
		NgayKetThuc = @NgayKetThuc,
		DieuTraVien = @DieuTraVien,
		DienThoaiDTV = @DienThoaiDTV,
		DiaDiemGiamDinh = @DiaDiemGiamDinh,
		DieuKienAnhSangThoiTiet = @DieuKienAnhSangThoiTiet,
		NguoiChungKien = @NguoiChungKien,
		NoiDungSuViec = @NoiDungSuViec,
		TienSuCaNhan = @TienSuCaNhan,
		NhanDangVaTinhTrangTuThi = @NhanDangVaTinhTrangTuThi,
		CacDauVetThuongTich = @CacDauVetThuongTich,
		KhamTrong = @KhamTrong,
		SoViThe1 = @SoViThe1,
		SoViThe2 = @SoViThe2,
		XetNghiemTeBao_MoBenhHoc = @XetNghiemTeBao_MoBenhHoc,
		CacXetNghiemKhac = @CacXetNghiemKhac,
		NguyenNhanChet = @NguyenNhanChet,
		PhuMo1 = @PhuMo1,
		PhuMo2 = @PhuMo2,
		GiamDinhVien1 = @GiamDinhVien1,
		GiamDinhVien2 = @GiamDinhVien2,
		TrinhDoVanHoa = @TrinhDoVanHoa,
		DanToc = @DanToc,
		TonGiao = @TonGiao,
		NgheNghiep = @NgheNghiep,
		XayRa = @XayRa,
		Tai = @Tai,
		KetQuaCanLamSang = @KetQuaCanLamSang,
		DauHieu = @DauHieu,
		KetLuanKhac = @KetLuanKhac 
	where MaHoSo = @MaHoSo
	
	IF(DATALENGTH(@HinhDuongSu) != 0)
	BEGIN
		UPDATE	TuThi
		SET		HinhDuongSu = @HinhDuongSu 
		WHERE	MaHoSo = @MaHoSo
	end
END







