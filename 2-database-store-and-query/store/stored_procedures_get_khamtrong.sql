USE [DBPhapY]
GO
/****** Object:  StoredProcedure [dbo].[get_khamtrong]    Script Date: 10/28/2014 21:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER proc [dbo].[get_khamtrong]
	@MaHoSo bigint
as
begin
	select * from KhamTrong where MaHoSo = @MaHoSo
end

