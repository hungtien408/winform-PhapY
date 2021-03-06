set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go















ALTER PROC [dbo].[update_tuthi]
		@MaHoSo bigint,
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
	update tuthi set
		SoHoSo = @SoHoSo,
		QDTCGDSo = @QDTCGDSo,
		CoQuanTrungCau = @CoQuanTrungCau,
		TinhThanh = @TinhThanh,
		KyNgay = @KyNgay,
		HoTen = @HoTen,
		HoTen1 = @HoTen1,
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
		ChanDoanYPhap = @ChanDoanYPhap,
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
		KetLuanKhac = @KetLuanKhac,
		DocChat = @DocChat,
		ADN = @ADN,
		HoSoTaiLieu = @HoSoTaiLieu,
		NoiDungYeuCau = @NoiDungYeuCau,
		NghienCuuHoSoBenhAn = @NghienCuuHoSoBenhAn
	where MaHoSo = @MaHoSo

	IF(DATALENGTH(@HinhDuongSu) != 0)
	BEGIN
		UPDATE	TuThi
		SET		HinhDuongSu = @HinhDuongSu 
		WHERE	MaHoSo = @MaHoSo
	end
END














