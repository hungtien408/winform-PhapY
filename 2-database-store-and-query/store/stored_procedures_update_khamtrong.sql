USE [DBPhapY]
GO
/****** Object:  StoredProcedure [dbo].[update_khamtrong]    Script Date: 10/28/2014 21:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER proc [dbo].[update_khamtrong]
	@MaHoSo bigint,
	@Dau nvarchar(2000),
	@Co nvarchar(2000),
	@Nguc nvarchar(2000),
	@Bung nvarchar(2000),
	@Tay nvarchar(2000),
	@Chan nvarchar(2000)
as
begin
	update KhamTrong set
		Dau = @Dau,
		Co = @Co,
		Nguc = @Nguc,
		Bung = @Bung,
		Tay = @Tay,
		Chan = @Chan
	where MaHoSo = @MaHoSo
end


