USE [DBPhapY]
GO

/****** Object:  Table [dbo].[TuThi]    Script Date: 10/28/2014 21:42:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TuThi](
	[MaHoSo] [bigint] IDENTITY(1,1) NOT NULL,
	[SoHoSo] [nvarchar](50) NULL,
	[QDTCGDSo] [nvarchar](50) NULL,
	[CoQuanTrungCau] [nvarchar](100) NULL,
	[TinhThanh] [nvarchar](100) NULL,
	[KyNgay] [datetime] NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [nvarchar](10) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[HinhDuongSu] [image] NULL,
	[QuocTich] [nvarchar](50) NULL,
	[NguoiGiamDinh] [nvarchar](1000) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[DieuTraVien] [nvarchar](50) NULL,
	[DienThoaiDTV] [nvarchar](50) NULL,
	[DiaDiemGiamDinh] [nvarchar](200) NULL,
	[DieuKienAnhSangThoiTiet] [nvarchar](200) NULL,
	[NguoiChungKien] [nvarchar](1000) NULL,
	[NoiDungSuViec] [nvarchar](2000) NULL,
	[TienSuCaNhan] [nvarchar](1000) NULL,
	[NhanDangVaTinhTrangTuThi] [nvarchar](2000) NULL,
	[CacDauVetThuongTich] [nvarchar](max) NULL,
	[KhamTrong] [nvarchar](max) NULL,
	[SoViThe1] [nvarchar](10) NULL,
	[SoViThe2] [nvarchar](10) NULL,
	[XetNghiemTeBao_MoBenhHoc] [nvarchar](max) NULL,
	[CacXetNghiemKhac] [nvarchar](1000) NULL,
	[NguyenNhanChet] [nvarchar](1000) NULL,
	[PhuMo1] [nvarchar](100) NULL,
	[PhuMo2] [nvarchar](100) NULL,
	[GiamDinhVien1] [nvarchar](100) NULL,
	[GiamDinhVien2] [nvarchar](100) NULL,
	[Available] [bit] NULL,
	[DangOPhong] [nvarchar](100) NULL,
	[TinhTrangHoSo] [bit] NULL,
	[TrinhDoVanHoa] [nvarchar](100) NULL,
	[DanToc] [nvarchar](50) NULL,
	[TonGiao] [nvarchar](50) NULL,
	[NgheNghiep] [nvarchar](100) NULL,
	[XayRa] [nvarchar](100) NULL,
	[Tai] [nvarchar](100) NULL,
	[KetQuaCanLamSang] [nvarchar](2000) NULL,
	[DauHieu] [nvarchar](2000) NULL,
	[KetLuanKhac] [nvarchar](2000) NULL,
 CONSTRAINT [PK_TuThi_1] PRIMARY KEY CLUSTERED 
(
	[MaHoSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[TuThi] ADD  CONSTRAINT [DF_TuThi_TinhTrangHoSo]  DEFAULT ((0)) FOR [TinhTrangHoSo]
GO


