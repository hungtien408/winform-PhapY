USE [DBPhapY]
GO
/****** Object:  StoredProcedure [dbo].[get_khamngoai]    Script Date: 10/28/2014 21:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER proc [dbo].[get_khamngoai]
	@MaHoSo bigint
as
begin
	select * from KhamNgoai where MaHoSo = @MaHoSo
end

