USE [DBPhapY]
GO

/****** Object:  Table [dbo].[KhamTrong]    Script Date: 10/28/2014 21:40:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KhamTrong](
	[MaHoSo] [bigint] NOT NULL,
	[Dau] [nvarchar](2000) NULL,
	[Co] [nvarchar](2000) NULL,
	[Nguc] [nvarchar](2000) NULL,
	[Bung] [nvarchar](2000) NULL,
	[Tay] [nvarchar](2000) NULL,
	[Chan] [nvarchar](2000) NULL,
 CONSTRAINT [PK_KhamTrong] PRIMARY KEY CLUSTERED 
(
	[MaHoSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[KhamTrong]  WITH CHECK ADD  CONSTRAINT [FK_KhamTrong_TuThi] FOREIGN KEY([MaHoSo])
REFERENCES [dbo].[TuThi] ([MaHoSo])
GO

ALTER TABLE [dbo].[KhamTrong] CHECK CONSTRAINT [FK_KhamTrong_TuThi]
GO


