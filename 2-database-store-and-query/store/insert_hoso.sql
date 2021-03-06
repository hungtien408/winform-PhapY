set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



















ALTER PROCEDURE [dbo].[insert_hoso]
(
	@SoHoSo nvarchar(50),
	@QDTCGDSo nvarchar(50),
	@CoQuanTrungCau nvarchar(100),
	@KyNgay datetime,
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
)
AS
BEGIN
	INSERT INTO HoSo (
		SoHoSo,
		QDTCGDSo,
		CoQuanTrungCau,
		KyNgay,
		HoTen,
		HinhDuongSu,
		QuocTich,
		NgayDenLamHoSo,
		TaiKham,
		NamSinh,
		GioiTinh,
		DiaChi,
		TamTru,
		XayRaNgay,
		Tai,
		TrinhDoVanHoa,
		DanToc,
		TonGiao,
		NgheNghiep,
		DienThoai,
		DieuTraVien,
		DienThoaiDTV,
		GiayQDTCGD,
		GiayCNTT,
		YChung,
		GiayRaVien,
		ToaThuoc,
		SoKhamBenh,
		GiayXacNhanNamVien,
		BenhAnTomTat,
		Khac,
		TT,
		SK,
		YC,
		DT,
		QHS,
		TD,
		NguoiNhanHoSo,
		TongSoKhamChuyenKhoa,
		Available,
		MaLoaiHSTTKT
	) VALUES (
		@SoHoSo,
		@QDTCGDSo,
		@CoQuanTrungCau,
		@KyNgay,
		@HoTen,	
		@HinhDuongSu,
		@QuocTich,	
		@NgayDenLamHoSo,
		@TaiKham,
		@NamSinh,
		@GioiTinh,
		@DiaChi,
		@TamTru,
		@XayRaNgay,
		@Tai,
		@TrinhDoVanHoa,
		@DanToc,
		@TonGiao,
		@NgheNghiep,
		@DienThoai,
		@DieuTraVien,
		@DienThoaiDTV,
		@GiayQDTCGD,
		@GiayCNTT,
		@YChung,
		@GiayRaVien,
		@ToaThuoc,
		@SoKhamBenh,
		@GiayXacNhanNamVien,
		@BenhAnTomTat,
		@Khac,
		@TT,
		@SK,
		@YC,
		@DT,
		@QHS,
		@TD,
		@NguoiNhanHoSo,
		@TongSoKhamChuyenKhoa,
		'1',
		@MaLoaiHSTTKT
	)
	DECLARE @ID int
	DECLARE @row_number int
	SELECT	@ID = SCOPE_IDENTITY();
	
	SELECT	@row_number = Row - 1
	FROM
			(SELECT ROW_NUMBER() OVER (ORDER BY NgayDenLamHoSo desc)AS Row, MaHoSo 
			FROM HoSo where Available = '1') AS DS
	WHERE	MaHoSo = @ID
	insert into PhuLucThuongTich(MaHoSo) values(@ID)
	SELECT	@row_number
END










