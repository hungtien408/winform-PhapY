Update PhuLucThuongTich SET BenhAnCapCuu = 'False' Where MaHoSo in (Select MaHoSo FROM HoSo)
GO
Update PhuLucThuongTich SET BenhAnNgoaiChuan = 'False' Where MaHoSo in (Select MaHoSo FROM HoSo)
GO
Update PhuLucThuongTich SET CNHH = PhuLucThuongTich.MRI Where MaHoSo in (Select MaHoSo FROM HoSo)