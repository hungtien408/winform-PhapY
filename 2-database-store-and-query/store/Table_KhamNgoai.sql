USE [DBPhapY]
GO

/****** Object:  Table [dbo].[KhamNgoai]    Script Date: 10/28/2014 21:40:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KhamNgoai](
	[MaHoSo] [bigint] NOT NULL,
	[MoTaTuTheTuThi] [nvarchar](2000) NULL,
	[DacDiemQuanAoMauSac] [nvarchar](2000) NULL,
	[TinhTrangDauMat] [nvarchar](2000) NULL,
	[Co] [nvarchar](2000) NULL,
	[Nguc] [nvarchar](2000) NULL,
	[Bung] [nvarchar](2000) NULL,
	[Lung] [nvarchar](2000) NULL,
	[Mong] [nvarchar](2000) NULL,
	[CoQuanSinhDuc] [nvarchar](2000) NULL,
	[HauMon] [nvarchar](2000) NULL,
	[Tay] [nvarchar](2000) NULL,
	[Chan] [nvarchar](2000) NULL,
 CONSTRAINT [PK_KhamNgoai] PRIMARY KEY CLUSTERED 
(
	[MaHoSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[KhamNgoai]  WITH CHECK ADD  CONSTRAINT [FK_KhamNgoai_TuThi] FOREIGN KEY([MaHoSo])
REFERENCES [dbo].[TuThi] ([MaHoSo])
GO

ALTER TABLE [dbo].[KhamNgoai] CHECK CONSTRAINT [FK_KhamNgoai_TuThi]
GO


