set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go















ALTER PROC [dbo].[update_hoso]
	@MaHoSo int ,
	@SoHoSo nvarchar(50),
	@QDTCGDSo nvarchar(50) ,
	@CoQuanTrungCau nvarchar(100),
	@KyNgay datetime ,
	@HoTen nvarchar(50),
	@HinhDuongSu image,
	@QuocTich nvarchar(50),
	@NgayDenLamHoSo datetime,
	@TaiKham bit,
	@NamSinh nvarchar(10),
	@GioiTinh bit,
	@DiaChi nvarchar(500),
	@TamTru nvarchar(500),
	@XayRaNgay datetime,
	@Tai nvarchar(100),
	@TrinhDoVanHoa nvarchar(50),
	@DanToc nvarchar(50),
	@TonGiao nvarchar(50),
	@NgheNghiep nvarchar(50),
	@DienThoai nvarchar(50),
	@DieuTraVien nvarchar(50),
	@DienThoaiDTV nvarchar(50),
	@GiayQDTCGD bit,
	@GiayCNTT bit,
	@YChung bit,
	@GiayRaVien bit,
	@ToaThuoc bit,
	@SoKhamBenh bit,
	@GiayXacNhanNamVien bit,
	@BenhAnTomTat bit,
	@Khac nvarchar(50),
	@TT bit,
	@SK bit,
	@YC bit,
	@DT bit,
	@QHS bit,
	@TD bit,
	@NguoiNhanHoSo nvarchar(50),
	@TongSoKhamChuyenKhoa nvarchar(5),
	@MaLoaiHSTTKT smallint
AS
BEGIN
	UPDATE	HoSo
	SET
			SoHoSo = @SoHoSo,
			QDTCGDSo = @QDTCGDSo,
			CoQuanTrungCau = @CoQuanTrungCau,
			KyNgay = @KyNgay,
			HoTen = @HoTen,
			QuocTich = @QuocTich,
			NgayDenLamHoSo = @NgayDenLamHoSo,
			TaiKham = @TaiKham,
			NamSinh = @NamSinh,
			GioiTinh = @GioiTinh,
			DiaChi = @DiaChi,
			TamTru = @TamTru,
			XayRaNgay = @XayRaNgay,
			Tai = @Tai,
			TrinhDoVanHoa = @TrinhDoVanHoa,
			DanToc = @DanToc,
			TonGiao = @TonGiao,
			NgheNghiep = @NgheNghiep,
			DienThoai = @DienThoai,
			DieuTraVien = @DieuTraVien,
			DienThoaiDTV = @DienThoaiDTV,
			GiayQDTCGD = @GiayQDTCGD,
			GiayCNTT = @GiayCNTT,
			YChung = @YChung,
			GiayRaVien = @GiayRaVien,
			ToaThuoc = @ToaThuoc,
			SoKhamBenh = @SoKhamBenh,
			GiayXacNhanNamVien = @GiayXacNhanNamVien,
			BenhAnTomTat = @BenhAnTomTat,
			Khac = @Khac,
			TT = @TT,
			SK = @SK,
			YC = @YC,
			DT = @DT,
			QHS = QHS,
			TD = @TD,
			NguoiNhanHoSo = @NguoiNhanHoSo,
			TongSoKhamChuyenKhoa = @TongSoKhamChuyenKhoa,
			MaLoaiHSTTKT = @MaLoaiHSTTKT
	WHERE	MaHoSo = @MaHoSo
	
	IF(DATALENGTH(@HinhDuongSu) != 0)
	BEGIN
		UPDATE	HoSo
		SET		HinhDuongSu = @HinhDuongSu 
		WHERE	MaHoSo = @MaHoSo
	end

	DECLARE @row_number int
	SELECT	@row_number = Row -1
	FROM
			(SELECT ROW_NUMBER() OVER (ORDER BY NgayDenLamHoSo desc)AS Row, MaHoSo 
			FROM HoSo where Available = '1') AS DS
	WHERE	MaHoSo = @MaHoSo
	SELECT	@row_number
end













