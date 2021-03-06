USE [DBPhapY]
GO
/****** Object:  StoredProcedure [dbo].[update_khamngoai]    Script Date: 10/28/2014 21:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER proc [dbo].[update_khamngoai]
	@MaHoSo bigint,
	@MoTaTuTheTuThi nvarchar(2000),
	@DacDiemQuanAoMauSac nvarchar(2000),
	@TinhTrangDauMat nvarchar(2000),
	@Co nvarchar(2000),
	@Nguc nvarchar(2000),
	@Bung nvarchar(2000),
	@Lung nvarchar(2000),
	@Mong nvarchar(2000),
	@CoQuanSinhDuc nvarchar(2000),
	@HauMon nvarchar(2000),
	@Tay nvarchar(2000),
	@Chan nvarchar(2000)
as
begin
	update KhamNgoai set
		MoTaTuTheTuThi = @MoTaTuTheTuThi,
		DacDiemQuanAoMauSac = @DacDiemQuanAoMauSac,
		TinhTrangDauMat = @TinhTrangDauMat,
		Co = @Co,
		Nguc = @Nguc,
		Bung = @Bung,
		Lung = @Lung,
		Mong = @Mong,
		CoQuanSinhDuc = @CoQuanSinhDuc,
		HauMon = @HauMon,
		Tay = @Tay,
		Chan = @Chan
	where MaHoSo = @MaHoSo
end


